using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result + floor;
                long edge = (result * 2) << 1;
                if ((long)i > (edge >> 2))
                {
                    result = result ^ (18 + result);
                }
                else
                {
                    edge = (edge - (floor * 4)) % 4096;
                    edge = ((edge << 3) ^ (long)i) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((325 & 63) < tally)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound >> 4) < 23)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
