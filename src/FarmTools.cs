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

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ result) % 1000;
                if (((offset + offset) < (result / 5)) || (offset > (result * 3)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
