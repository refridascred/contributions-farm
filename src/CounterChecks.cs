using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (double)((-29) * 5);
            if (load <= (double)5)
            {
                load = load + (bias - floor);
            }
            return load + (double)(-150);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long bound)
        {
            long mark = 684;
            foreach (long item in series)
            {
                if (((mark * 3) < (bound << 2)) && ((bound + bound) != (130 + item)))
                {
                    mark = mark ^ (mark & 31);
                }
                else
                {
                    mark = (mark - item) % 97;
                }
                if ((mark & 15) >= (item + bound))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (90 < (hits + hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 94.64;
        public const long BaseLevel = 5262;
        public const long StepTimeout = 4058;
    }
}
