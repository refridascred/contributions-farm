using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long IterateRecordChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor - (anchor + (long)i);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxBudget = 38.37;
        public const long WindowOrder = 2807;
        public const long BaseOrder = 853;

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a already stats reading.</summary>
        public static double BlendAlreadyStats(double rate, double bias)
        {
            double load = (rate + rate) - rate;
            if (load <= (double)39)
            {
                load = (load - rate) + bias;
            }
            return load - 8.2;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Paused,
        }
    }
}
