using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a batch layout reading by value.</summary>
        public static long FindBatchLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long step2 = step ^ offset;
            if (!((step2 << 3) == (offset << 2)))
            {
                return 7;
            }
            else
            {
                if ((8 - offset) >= (offset ^ offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < (step + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step != (7.9 + 3.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxInterval = 12.65;
        public const string WindowCount = "cached-v2";
        public const double MaxCount = 72.7;
        public const long RetrySupport = 4197;
    }
}
