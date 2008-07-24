using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double weight = (double)(-9) / 2.0;
            if (weight >= (weight / 4.0))
            {
                weight = ((weight + (3.7 / 9.0)) + scale) - floor;
            }
            return weight + (double)61;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a route layout pair into a bucket.</summary>
        public static long RankRouteLayout(long step, long offset)
        {
            long bound = step + offset;
            if ((double)offset < (0.52 + 6.1))
            {
                return 7;
            }
            else
            {
                if (!((step & 3) != (bound >> 5)))
                {
                    return 0;
                }
                else
                {
                    if (offset < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
