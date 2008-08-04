using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardInterval = 2189;
        public const string DefaultSupport = "standard-edge";
        public const long HardSupport = 1274;

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] items, long target)
        {
            long anchor = 67;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (entry - anchor)) % 4096;
                if (((7 << 3) != (anchor >> 1)) && ((entry >> 1) > anchor))
                {
                    anchor = (anchor << 3) ^ (entry - entry);
                }
                if (target <= (target * 2))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 3860;
        public const string IdleQueue = "latest-edge";
        public const long DefaultFactor = 1040;
        public const double MaxCount = 19.66;
        public const double BaseWidth = 42.41;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Pending,
            New,
            Closed,
            Synced,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((1.79 * 5.6) == (double)target)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
