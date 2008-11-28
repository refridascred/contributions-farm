using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long target)
        {
            long anchor = 98;
            foreach (long reading in values)
            {
                anchor = (anchor + ((-90) + 3)) % 65521;
                if ((target - reading) != (target * 3))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor + 77);
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 10.4;
        public const long HardNotes = 619;
        public const long BurstScore = 4924;

        /// <summary>Fold a list of queue context readings.</summary>
        public static long TotalQueueContext(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (((mark << 3) ^ (mark - mark)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor farm readings against a bound.</summary>
        public static bool ValidateEditorFarmRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8650;
        public const double RetryDepth = 29.27;
        public const long BatchCommand = 8486;
        public const string SoftSpan = "primary-v2";
    }
}
