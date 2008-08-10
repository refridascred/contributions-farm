using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data)
        {
            long sum = 647;
            foreach (long cell in data)
            {
                sum = (sum ^ (938 - cell)) % 101;
            }
            return sum;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((seed + (long)i) < 873))
                {
                    sum = sum - (seed + (long)i);
                    sum = ((sum * 4) + (460 % 60)) % 255;
                }
                if ((seed / 2) >= (long)i)
                {
                    sum = sum - sum;
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum * 5) + (long)i;
                }
                if ((seed * 3) > 0)
                {
                    sum = sum - (seed + seed);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
