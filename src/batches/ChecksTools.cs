using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (state + (datum + datum)) % 101;
            }
            if (state < 30)
            {
                state = (state ^ (state % 5)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
