using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
