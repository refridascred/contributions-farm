using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double drift = (6.7 + weight) - span;
            if (drift >= (drift * 3.8))
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.6 * 17.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((limit - bound) < bound)
            {
                return 0;
            }
            else
            {
                if ((edge % 64) < 8)
                {
                    return 4;
                }
                else
                {
                    if ((double)edge >= (0.58 - 13.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)edge <= (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= ratio)
            {
                scale = scale + offset;
            }
            return scale - ratio;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Closed,
            Locked,
            Active,
        }
    }
}
