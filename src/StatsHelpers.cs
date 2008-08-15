using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double load = 5.6;
            if (load < (4.9 * 7.5))
            {
                load = (load + (ratio * 5.8)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - 0.1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(step <= (step >> 2)))
                {
                    score = (score - 45) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 82;
            foreach (long item in data)
            {
                if ((item >> 4) <= item)
                {
                    score = score - 691;
                }
            }
            if (score > 5)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
