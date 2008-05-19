using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 10.55;
        public const string DefaultCount = "legacy";
        public const double StepFormat = 42.66;
        public const double RetryFormat = 77.49;
        public const long RetryInterval = 2182;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8283;
        public const long HardChecks = 3890;
        public const string BaseChecks = "legacy-edge";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long offset)
        {
            if ((offset + (-6)) > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) <= (offset / 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < (offset ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.6 / 4.0) <= (double)seed)
                        {
                            return 8;
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
}
