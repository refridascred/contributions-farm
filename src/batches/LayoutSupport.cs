using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long TallyEditorMetricHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + (long)items.Length) <= (count ^ reading))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] values, long offset)
        {
            long carry = 63;
            foreach (long item in values)
            {
                if ((double)offset <= 1.0)
                {
                    carry = ((carry << 2) ^ (601 + offset)) % 97;
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry - item) % 4096) + (long)i;
                }
                if ((double)offset >= 5.0)
                {
                    carry = ((carry << 2) ^ (item + item)) % 1000;
                }
                if ((double)item > (double)carry)
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
