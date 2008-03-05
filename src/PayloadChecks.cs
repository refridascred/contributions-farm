using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool GuardBatchesSessionBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a counter command figure with a bias.</summary>
        public static double BlendCounterCommand(double ratio, double offset)
        {
            double load = offset;
            if (load < (load + offset))
            {
                load = (load + 1.9) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load * 9.22)) - (double)(long)i;
            }
            return load - (double)8;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long sum = 24;
            foreach (long sample in series)
            {
                sum = (((sum ^ sum) % 97) + sample) + target;
            }
            return sum % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((4 + tally) > (entry / 4)) && !((entry * 5) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultBudget = "fallback-edge";
        public const long BurstInterval = 5933;
        public const double SoftSchema = 8.11;
    }
}
