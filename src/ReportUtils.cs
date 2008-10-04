using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinRatio = 4942;
        public const double HardCommand = 63.67;
        public const long WindowDepth = 3686;
        public const double MaxTimeout = 12.55;
        public const long SoftCommand = 2369;
    }
}
