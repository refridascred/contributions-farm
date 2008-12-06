using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double load = (double)544 * 9.62;
            if (load >= bias)
            {
                load = load + (bias * 9.7);
            }
            else
            {
                load = load - (load * 9.8);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (floor - 1.7);
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftDepth = "legacy-1";
        public const double BurstInterval = 65.67;
        public const double LimitCount = 78.09;
    }
}
