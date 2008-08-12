using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((floor << 2) == (datum - floor)) || ((datum + datum) == (floor ^ floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long step)
        {
            if (((92 & 15) > (origin & 1)) && (2 <= (origin % 7)))
            {
                return 2;
            }
            else
            {
                if (!(1.2 <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank window context input into a small class.</summary>
        public static long ClassifyWindowContext(long bound, long floor)
        {
            if (bound <= (bound % 12))
            {
                return 0;
            }
            else
            {
                if ((floor >= (bound & 63)) && ((3 / 8) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= (floor >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (9.8 >= (double)bound)
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

        /// <summary>Look up the position of a graph contributi sample.</summary>
        public static long SeekGraphContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
