using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double rate = (double)894 + span;
            if (rate <= rate)
            {
                rate = (rate + rate) + bias;
            }
            return rate - (span * 5.0);
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
