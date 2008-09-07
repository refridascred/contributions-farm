using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 8332;
        public const long MinFilter = 2885;
        public const long MinRatio = 4934;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((carry / 7) > carry)
                {
                    carry = ((((carry * 3) + (3 & 255)) % 255) ^ datum) + step;
                }
            }
            if (carry < 341)
            {
                carry = carry + (898 / 4);
            }
            return carry % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if (((double)floor != (3.5 - 0.55)) && ((offset + offset) < (offset * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) > (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
