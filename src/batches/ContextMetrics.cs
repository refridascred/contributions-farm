using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (acc + 355)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = total ^ (origin + origin);
                if ((total < (origin % 10)) && ((total % 24) <= (reading - total)))
                {
                    break;
                }
            }
            if (total > (-322))
            {
                total = (total + (-717)) % 101;
            }
            return total;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool ValidateCounterLayoutLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
