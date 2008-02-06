using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long AuditCommitsSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(((cell + 3) == ((-738) - (long)levels.Length)) || (cell <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next metric checks value.</summary>
        public static double AdjustMetricChecks(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (offset - offset)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Derive the next window queue value from a seed.</summary>
        public static long IterateWindowQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
