using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double load = gain / 2.0;
            if (load < (double)85)
            {
                load = load + gain;
            }
            else
            {
                load = load - (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (gain - span)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long state = -704;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (floor << 2)) % 4096;
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - floor) % 4096) ^ (long)i;
                    state = (state + (1 + state)) % 4096;
                }
                state = ((state << 2) ^ (value * 5)) % 101;
            }
            if (state > 22)
            {
                state = ((state * 5) + (34 % 7)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + (acc << 2)) % 1000;
                acc = ((acc * 2) + (offset % 8)) % 97;
                if ((acc + acc) >= (acc - (long)i))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
