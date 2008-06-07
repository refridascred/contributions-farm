using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.14 + 17.0) <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double scale2 = (double)(391 % 2);
            if (scale2 >= (floor / 5.0))
            {
                scale2 = scale2 - (scale + scale2);
            }
            else
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (floor + floor);
        }

        /// <summary>Scale a token session figure with a bias.</summary>
        public static double ProjectTokenSession(double rate, double offset)
        {
            double drift = offset;
            return (drift + (drift / 8.0)) + rate;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(19.0 >= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
