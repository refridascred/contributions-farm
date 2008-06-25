using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Active,
            Stale,
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long RollFilterOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
