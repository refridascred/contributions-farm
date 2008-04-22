using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 2035;
        public const long LimitCount = 3870;
        public const long MinWidth = 889;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if (13 < limit)
                {
                    mark = (((mark << 2) ^ (mark + limit)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Measure how many buffer stream samples are out of range.</summary>
        public static long TallyBufferStreamGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 97) >= (reading - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long seed2)
        {
            if (((18.0 - 20.0) != (double)seed) || (((-522) & 63) < (seed & 3)))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) < (seed % 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 * 2) != (seed >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.0 - 1.0) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = -2;
            foreach (long entry in levels)
            {
                if (!((state & 127) >= (entry / 7)))
                {
                    state = state + (entry * 3);
                }
            }
            return state;
        }
    }
}
