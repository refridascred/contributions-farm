using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 33) < 80)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseScore = 83.07;
        public const long DefaultNotes = 6459;
        public const long BurstTimeout = 1008;
        public const long RetryNotes = 6959;
        public const string WindowNotes = "open";

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double floor)
        {
            double ratio = scale / 9.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (6.94 / 3.0)) + (double)(long)i) + floor;
            }
            return ratio + (double)212;
        }
    }
}
