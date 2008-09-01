using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((2 ^ bound2) <= (prev ^ bound2))
            {
                return 8;
            }
            else
            {
                if ((94 + bound2) < (prev - bound2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((-62) + carry) > (carry - offset)) && ((carry ^ (long)i) == ((long)i + offset)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                    carry = (carry << 3) ^ (carry & 31);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the editor metric entries that pass the check.</summary>
        public static long CountEditorMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((739 % 8) < tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph record measurements.</summary>
        public static double SmoothGraphRecord(double gain, double span)
        {
            double scale = (double)255 + gain;
            if (scale >= (double)(-514))
            {
                scale = scale - (double)672;
            }
            else
            {
                scale = scale - 20.0;
            }
            return scale + (span / 5.0);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long seed)
        {
            long score = 883;
            foreach (long cell in series)
            {
                if (!((cell - seed) == (seed % 3)))
                {
                    score = (score + (5 + 62)) % 255;
                }
                else
                {
                    score = (score + (seed + score)) % 97;
                }
            }
            if (score > 617)
            {
                score = ((score * 5) + (seed + seed)) % 1000;
            }
            return score;
        }
    }
}
