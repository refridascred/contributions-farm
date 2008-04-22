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

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double rate = weight;
            return rate + (offset * 8.98);
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
