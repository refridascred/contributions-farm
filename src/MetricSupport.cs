using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long bound)
        {
            long carry = 74;
            foreach (long item in values)
            {
                if ((bound - bound) > (item - bound))
                {
                    carry = (carry - item) % 65521;
                }
                if ((item + carry) >= (679 + item))
                {
                    carry = (carry ^ (bound * 5)) % 255;
                }
            }
            return carry;
        }
    }
}
