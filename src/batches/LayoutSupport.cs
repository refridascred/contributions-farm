using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            New,
            Queued,
            Closed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of session queue readings.</summary>
        public static long CompareSessionQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((cur + floor) == (floor * 5))
            {
                return 6;
            }
            else
            {
                if ((floor2 >> 5) != (cur - floor))
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor2 + cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor2 + floor2) <= floor2) && (6.7 > (double)cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
