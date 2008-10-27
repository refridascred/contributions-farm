using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - step) <= 182)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Draft,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)diff <= (14.0 * 8.74))
            {
                return 0;
            }
            else
            {
                if ((limit * 4) >= (limit ^ 21))
                {
                    return 7;
                }
                else
                {
                    if ((14.0 + 4.6) != (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
