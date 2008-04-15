using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long origin)
        {
            long bound = step + origin;
            if (((double)origin >= (20.0 + 3.7)) && ((73 ^ 39) == (step / 2)))
            {
                return 8;
            }
            else
            {
                if ((bound < 375) || ((step - step) > (bound + 6)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step + 817))
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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
