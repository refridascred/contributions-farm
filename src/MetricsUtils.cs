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

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (step / 7)) % 97;
                total = (total ^ (total & 15)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
