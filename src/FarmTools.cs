using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long PairGithubfarmChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin & 15) <= (origin + (long)i))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings, long step)
        {
            long carry = 75;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = carry ^ (value + (long)i);
                }
                if (carry <= (value + carry))
                {
                    carry = (carry << 2) ^ (carry % 12);
                }
                else
                {
                    carry = carry ^ (value & 15);
                }
            }
            if (carry < (-506))
            {
                carry = ((carry << 3) ^ (step % 5)) % 1000;
            }
            return carry;
        }
    }
}
