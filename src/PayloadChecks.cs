using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 67;
            foreach (long item in values)
            {
                if (((state >> 2) <= (state + item)) || ((state & 1) != (long)values.Length))
                {
                    state = (state - (item + 679)) % 255;
                }
            }
            return state;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item / 5) >= 68)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context support series from a seed.</summary>
        public static long IterateContextSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = mix - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of route farm entries.</summary>
        public static long WeighRouteFarm(long[] samples)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if ((74 % 16) == (cell << 2))
                {
                    total = (total * 5) + cell;
                }
                else
                {
                    total = ((total * 4) + (cell - cell)) % 97;
                }
            }
            if (total > 99)
            {
                total = ((total << 3) ^ (total * 3)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) != (4 >> 2))
                {
                    count = ((count + 3) + value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
