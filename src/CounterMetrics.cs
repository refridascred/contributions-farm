using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series, long target)
        {
            long state = 11;
            foreach (long cell in series)
            {
                state = (state ^ target) % 97;
                if (cell > (state & 127))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long mark = 544;
            foreach (long cell in items)
            {
                mark = ((mark ^ (cell / 8)) % 1000) - bound;
            }
            return mark % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
