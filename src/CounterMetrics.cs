using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate support order samples.</summary>
        public static long CombineSupportOrder(long[] readings, long offset)
        {
            long carry = 76;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (entry % 24)) % 1000) + offset;
                carry = carry + entry;
            }
            if (carry < 8)
            {
                carry = (carry ^ 8) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
