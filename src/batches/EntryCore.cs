using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long target)
        {
            long anchor = -30;
            foreach (long cell in levels)
            {
                if ((cell >= target) && ((9.52 / 5.0) >= (double)anchor))
                {
                    anchor = (anchor << 3) ^ ((-1) ^ 96);
                    anchor = anchor - anchor;
                }
                anchor = (anchor ^ (12 + target)) % 255;
            }
            return anchor;
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
