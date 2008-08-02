using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + tally) <= (tally & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double floor)
        {
            double mean = 17.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)(long)i) + gain) - floor;
            }
            return mean + mean;
        }

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long CountGithubfarmAlreadyOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || (((2 - datum) < (seen + datum)) || (origin < (seen - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
