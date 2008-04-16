using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading < (523 & 7)))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double weight = (double)7;
            if (weight >= (7.0 + floor))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (weight - 4.89);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits > (item + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin - origin) <= origin)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings)
        {
            long acc = 68;
            foreach (long reading in readings)
            {
                if (!(acc > (acc ^ reading)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 423;
        public const double WindowAlready = 93.79;
        public const long StepAlready = 7238;
        public const long MaxTimeout = 7039;
    }
}
