using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the token layout series from a seed.</summary>
        public static long DeriveTokenLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long RollCounterChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)floor < (10.0 + 4.2))
                {
                    total = (total * 5) + floor;
                }
                else
                {
                    total = (total * 4) + (floor + total);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total - (total / 4)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 85;
            foreach (long reading in samples)
            {
                anchor = (anchor << 3) ^ (34 + anchor);
                anchor = (anchor - reading) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long offset)
        {
            if ((offset >> 1) <= offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset < (0.9 * 1.0)) && (((-621) << 2) >= step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
