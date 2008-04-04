using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ item) % 255) - (long)i2;
                }
                if ((item / 4) >= (item / 5))
                {
                    result = (result + (result + 77)) % 4096;
                }
                if ((19 > result) && ((double)result != (6.17 / 2.0)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long bound2)
        {
            if (!(bound2 >= (bound / 7)))
            {
                return 4;
            }
            else
            {
                if (2.8 >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) <= (bound2 / 4))
                    {
                        return 2;
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
