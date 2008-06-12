using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up session commits samples.</summary>
        public static long CompareSessionCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                long delta = offset;
                if (((double)offset != (double)delta) && ((double)(long)i <= (17.0 - 2.8)))
                {
                    acc = acc + delta;
                    acc = ((acc * 3) + (long)i) % 65521;
                }
                else
                {
                    delta = delta ^ (3 - acc);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double weight = (double)(11 - 187);
            return (weight + ratio) + bias;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long floor)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((double)acc >= (6.0 * 3.38)) && ((double)floor <= (1.9 - 13.0)))
                {
                    acc = acc + (floor + item);
                }
            }
            return acc % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen < 6.0) || (((-261) * 2) == (cell - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
