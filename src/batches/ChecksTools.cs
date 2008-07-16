using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((884 * 3) == (origin * 4))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series, long bound)
        {
            long carry = 11;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (bound + bound)) - reading;
            }
            return carry % 65521;
        }

        /// <summary>Match up metrics account samples.</summary>
        public static long OverlapMetricsAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
