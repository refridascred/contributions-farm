using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm record readings.</summary>
        public static long FoldFarmRecord(long[] readings, long offset)
        {
            long sum = 51;
            foreach (long reading in readings)
            {
                if (((reading * 2) != (offset % 7)) && ((13.0 * 0.4) < (double)sum))
                {
                    sum = (sum + sum) % 101;
                    sum = ((sum << 3) ^ (373 * 2)) % 97;
                }
                if ((10 - sum) != (offset - sum))
                {
                    sum = sum + (offset / 4);
                }
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((bound >> 5) < bound) && ((bound & 7) > 256))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
