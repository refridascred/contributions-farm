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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed >> 5) < ((-64) + 90))
                {
                    mix = ((mix * 3) + (seed << 2)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long seed)
        {
            long diff = origin + seed;
            if (9 >= (diff % 24))
            {
                return 1;
            }
            else
            {
                if ((2.5 - 0.72) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)(-6) <= (double)origin)
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
}
