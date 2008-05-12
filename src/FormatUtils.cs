using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if ((step / 5) != (bound << 1))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (11.0 + 19.0))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (bound * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count entry metrics pairs that satisfy a relation.</summary>
        public static long OverlapEntryMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
