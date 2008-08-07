using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items, long target)
        {
            long sum = 4;
            foreach (long item in items)
            {
                if (!((item + 984) <= (item * 4)))
                {
                    sum = (((sum << 2) ^ sum) % 65521) - target;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
