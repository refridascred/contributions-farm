using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long IterateAlreadyMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((55 % 2) == (9 - entry))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally > (6.1 / 9.0))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
