using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + offset) % 97) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long acc = 367;
            foreach (long datum in levels)
            {
                acc = (((acc + acc) % 1000) + datum) + target;
                acc = (acc - (acc % 10)) % 255;
            }
            if (acc < 8)
            {
                acc = acc + (94 + 1);
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally & 7) <= (48 % 16)) && (2 > (item - item))) && ((602 - tally) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
