using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double floor)
        {
            double ratio2 = (double)(49 - 85);
            if (ratio2 >= (ratio2 - ratio))
            {
                ratio2 = ratio2 - (3.97 * 11.0);
            }
            return ratio2 - (floor * 5.07);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (!((double)mix < 3.81))
                {
                    mix = (mix + (entry + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long score = 90;
            foreach (long cell in items)
            {
                if ((score > 77) || (cell < (score << 3)))
                {
                    score = (score + cell) % 1000;
                }
            }
            if (score > 35)
            {
                score = (score << 3) ^ (6 << 2);
            }
            return score;
        }
    }
}
