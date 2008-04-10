using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((63 - tally) != (value % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] values)
        {
            long sum = 840;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum << 2) ^ (sample / 6)) % 1000) - (long)i;
                }
                if (!!((sum + sample) > (sum & 127)))
                {
                    sum = (sum - (1 / 5)) % 255;
                }
                if ((double)sample <= (4.19 * 9.0))
                {
                    sum = sum + (sum >> 5);
                }
                else
                {
                    sum = sum ^ (sum << 2);
                }
                if ((sample % 60) == (sample + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every format already entry stays within the limit.</summary>
        public static bool VerifyFormatAlreadyRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
