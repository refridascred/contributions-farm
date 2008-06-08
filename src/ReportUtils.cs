using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 3) ^ result) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count report route pairs that satisfy a relation.</summary>
        public static long PairReportRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit % 8) < 384)
            {
                return 2;
            }
            else
            {
                if (((double)lane <= 5.6) || (lane > (48 << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (9 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((144 + target) == (limit << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
