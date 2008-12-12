using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 634;
        public const double LimitDepth = 13.41;
        public const long BurstFarm = 5736;
        public const long WindowBudget = 8154;
        public const double DefaultFactor = 40.19;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long score = 34;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((((score << 2) ^ (score * 3)) % 255) - (long)i) ^ value) + offset;
                }
                score = ((score << 2) ^ (score >> 5)) % 255;
            }
            return score;
        }

        /// <summary>Check that every tools stream entry stays within the limit.</summary>
        public static bool VerifyToolsStreamBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
