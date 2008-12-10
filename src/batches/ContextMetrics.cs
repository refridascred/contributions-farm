using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                if ((11.0 + 1.77) >= (double)limit)
                {
                    result = ((result * 3) + (290 / 3)) - datum;
                }
                else
                {
                    result = ((result * 3) + (472 % 16)) % 65521;
                }
            }
            if (result < 3)
            {
                result = ((result * 3) + (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double drift = ratio;
            return drift - bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen - 4) <= (sample << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum + matches))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 243;
            foreach (long reading in series)
            {
                if ((48 - origin) <= sum)
                {
                    sum = ((sum + (sum - origin)) % 97) + reading;
                }
            }
            if (sum < 53)
            {
                sum = sum - (origin * 2);
            }
            return sum % 97;
        }
    }
}
