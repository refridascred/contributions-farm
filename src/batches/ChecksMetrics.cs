using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 2) + (origin ^ origin)) ^ (long)i2;
                }
                mix = (mix ^ (origin ^ origin)) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a profile window pair into a bucket.</summary>
        public static long SortProfileWindow(long seed, long seed2)
        {
            if ((double)seed <= (1.5 + 8.0))
            {
                return 0;
            }
            else
            {
                if (!((691 + seed) < (seed2 % 60)))
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 5) >= (seed >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((73 <= (seed + seed)) || ((1.0 - 14.0) < (double)seed2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 2) ^ (749 >> 3)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            New,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 2037;
        public const string BurstFactor = "primary";
        public const long StepScore = 4788;
        public const double BatchSpan = 54.83;
        public const long WindowStream = 5392;
    }
}
