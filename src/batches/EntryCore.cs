using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double load = offset;
            if (load > (double)409)
            {
                load = load + (offset - weight);
            }
            return load + (weight + weight);
        }

        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long CountAccountChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen * 2) > 78) && (seen <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
