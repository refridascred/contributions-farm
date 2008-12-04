using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleScore = 58.57;
        public const long BatchWidth = 1097;
        public const long BatchFarm = 5774;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6950;
        public const long HardScore = 4349;
        public const long MaxDepth = 3544;

        /// <summary>Count the layout report entries that pass the check.</summary>
        public static long MeasureLayoutReportHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
