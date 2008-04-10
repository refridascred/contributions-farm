using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long sample in series)
            {
                if (!((double)origin == (double)anchor))
                {
                    anchor = anchor - (origin % 8);
                }
                if ((18.0 - 2.0) == (double)origin)
                {
                    anchor = (anchor - (anchor + sample)) % 97;
                }
                else
                {
                    anchor = (anchor - (origin - origin)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (limit - total)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Classify a metric entry pair into a bucket.</summary>
        public static long SortMetricEntry(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (cur < bound)
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) != (cur - seed))
                {
                    return 3;
                }
                else
                {
                    if (96 >= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed ^ bound) == (8 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
