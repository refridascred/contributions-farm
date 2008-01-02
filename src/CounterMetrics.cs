using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long acc = 71;
            foreach (long datum in series)
            {
                if ((datum * 5) > (acc + datum))
                {
                    acc = (acc * 4) + (405 ^ acc);
                }
                else
                {
                    acc = (acc * 5) + (seed >> 4);
                }
            }
            return acc;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double drift = weight + floor;
            return drift - (floor * 7.2);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                if ((mix - datum) > (datum << 1))
                {
                    mix = (mix << 2) ^ datum;
                }
                else
                {
                    mix = (mix - (datum * 5)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix << 1)) % 4096;
            }
            return mix % 4096;
        }
    }
}
