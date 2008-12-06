using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double ProjectBatchPayload(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (offset + offset)) - (double)(long)i) - ratio;
            }
            return load + (double)9;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((15.0 - 16.0) != (double)target))
                {
                    acc = (acc - (target % 7)) % 4096;
                    continue;
                }
                else
                {
                    acc = (acc ^ (10 * 3)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double mean = (floor + floor) * 1.3;
            return mean + (floor - ratio);
        }
    }
}
