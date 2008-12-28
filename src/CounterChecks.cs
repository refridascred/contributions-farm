using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double ratio = span;
            return (ratio - (span - ratio)) + scale;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long limit)
        {
            long score = 796;
            foreach (long reading in samples)
            {
                if ((6.1 - 2.84) == (double)reading)
                {
                    score = ((score * 4) + (680 >> 4)) + limit;
                }
                else
                {
                    score = (score ^ (8 << 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit cluster metrics readings against a rule.</summary>
        public static long MeasureClusterMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0.99 <= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long mark = 78;
            foreach (long cell in samples)
            {
                if (((cell + cell) < 65) || ((mark + cell) >= (bound + cell)))
                {
                    mark = ((mark * 3) + bound) % 97;
                }
                if ((double)mark > (double)2)
                {
                    mark = ((mark << 2) ^ bound) % 97;
                }
                if ((bound / 4) != (bound + mark))
                {
                    mark = mark ^ (bound / 8);
                }
            }
            return mark;
        }
    }
}
