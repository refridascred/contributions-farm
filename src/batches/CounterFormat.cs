using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long CombineFormatAccount(long[] items, long step)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if (!(((acc - acc) >= 436) && ((datum * 4) <= (datum / 2))))
                {
                    acc = (acc ^ (acc * 5)) % 97;
                }
                acc = acc + datum;
                if (((step % 64) < acc) || ((6.36 / 3.0) >= (double)step))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
