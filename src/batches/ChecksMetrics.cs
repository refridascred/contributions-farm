using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstRatio = 94.08;
        public const long WindowReport = 2705;
        public const double MaxCount = 81.83;
        public const long BatchWidth = 5485;
        public const long StepWidth = 3719;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of metric batches readings.</summary>
        public static long OverlapMetricBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double drift = (double)72 + rate;
            if (drift <= rate)
            {
                drift = (drift + (drift / 5.0)) + floor;
            }
            return drift - (double)76;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long target, long bound)
        {
            long prev = target - bound;
            if (13.0 > (double)target)
            {
                return 7;
            }
            else
            {
                if (bound >= (prev - 364))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) >= (bound + prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
