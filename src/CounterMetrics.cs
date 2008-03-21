using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                long tally = mark;
                if (!((step + 665) < (tally ^ tally)))
                {
                    mark = (mark * 4) + (mark + mark);
                    continue;
                }
                tally = ((tally << 2) ^ (4 / 2)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long state = 712;
            foreach (long value in samples)
            {
                if ((value / 3) < (31 % 100))
                {
                    state = state - (state + state);
                }
            }
            return state;
        }
    }
}
