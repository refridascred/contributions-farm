using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool CheckBatchNotesLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 3331;
        public const long StepSize = 5000;
        public const double CacheSpan = 52.42;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            New,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Validate counter tools readings against a bound.</summary>
        public static bool VerifyCounterToolsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) <= ((-9) >> 3))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
