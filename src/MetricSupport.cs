using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((double)target == (double)5) || (target >= (item ^ matches))) && (((matches ^ target) >= 4) && ((matches - matches) == (matches << 2))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((((result * 3) + (71 * 5)) % 65521) + reading) + limit;
                if ((result >> 4) > 35)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
