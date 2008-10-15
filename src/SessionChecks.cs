using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool GuardContextCommandRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen >> 5) > (72 + (long)data.Length)) && ((double)(-65) < (double)reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
