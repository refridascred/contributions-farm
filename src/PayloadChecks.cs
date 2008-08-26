using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings, long offset)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((offset - mix) < (reading % 97))
                {
                    mix = ((mix * 5) + (9 + reading)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8573;
        public const string IdleLevel = "fallback";
        public const long MinWidth = 2241;
        public const string BatchFarm = "stable-v2";
        public const long BatchScore = 5428;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 3572;
        public const long RetryFilter = 555;
        public const double RetryCount = 15.55;
        public const long MaxFilter = 1198;
        public const string BaseCount = "legacy-1";

        /// <summary>Compare every pair of metrics filter readings.</summary>
        public static long PairMetricsFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double weight = scale * 8.0;
            if (weight > (weight + 6.1))
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (offset + weight)) + (double)(long)i;
            }
            return weight - (double)820;
        }
    }
}
