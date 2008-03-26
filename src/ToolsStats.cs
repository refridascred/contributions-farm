using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = (bias + offset) + gain;
            }
            return bias - (double)63;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long step2)
        {
            if ((50 + step2) < (step / 2))
            {
                return 6;
            }
            else
            {
                if ((double)step < (8.0 - 2.46))
                {
                    return 8;
                }
                else
                {
                    if ((step2 + 244) > step2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 - step) < 356)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of context stats readings.</summary>
        public static long CompareContextStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
