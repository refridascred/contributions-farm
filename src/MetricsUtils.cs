using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long origin)
        {
            if ((origin + bound) >= origin)
            {
                return 7;
            }
            else
            {
                if (!((bound + origin) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (!((origin + bound) >= (bound - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin > (origin / 2)) && ((bound + bound) >= (origin + 97)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] series)
        {
            long state = 36;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (state + cell)) % 65521;
                if ((cell ^ 95) == (cell * 4))
                {
                    state = (state ^ (state >> 1)) % 255;
                }
                else
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 67)
            {
                state = (state - (state & 255)) % 65521;
            }
            return state % 65521;
        }
    }
}
