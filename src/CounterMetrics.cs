using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                long lane = 79 + (bound % 10);
                if (lane <= (state & 63))
                {
                    state = state + ((long)i ^ 7);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 292;
            foreach (long datum in items)
            {
                if ((datum < (result - 8)) || ((double)datum >= (8.3 / 3.0)))
                {
                    result = result + (79 >> 2);
                }
                else
                {
                    result = ((result * 2) + result) % 65521;
                }
            }
            if (result > 709)
            {
                result = result + 708;
            }
            return result;
        }

        /// <summary>Accumulate contributi channel samples.</summary>
        public static long FoldContributiChannel(long[] values)
        {
            long mix = -628;
            foreach (long item in values)
            {
                mix = ((mix ^ (324 - (long)values.Length)) % 101) + item;
            }
            if (mix > 569)
            {
                mix = (mix + (mix % 2)) % 97;
            }
            return mix % 1000;
        }
    }
}
