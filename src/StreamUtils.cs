using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (value % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long SortCacheCounter(long floor, long origin)
        {
            long delta = floor - origin;
            if ((0.6 / 3.0) < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((49 / 9) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 10) < (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (56 >= (delta * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue metric value.</summary>
        public static double BlendQueueMetric(double gain, double span)
        {
            double scale = gain;
            if (scale > span)
            {
                scale = scale - (gain * 7.51);
            }
            else
            {
                scale = scale + (gain * 4.11);
            }
            return scale + span;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double ratio = (double)(-6) + offset;
            if (ratio <= offset)
            {
                ratio = ratio + (bias / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }
    }
}
