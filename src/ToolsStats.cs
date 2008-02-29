using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowTimeout = 5450;
        public const string MinReport = "stable-v2";
        public const double BaseInterval = 89.69;
        public const double CacheFactor = 91.88;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 4007;
        public const long BurstEntry = 7379;
        public const double CacheWidth = 9.87;
        public const long HardSpan = 4953;
        public const long CacheEntry = 6431;

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long step)
        {
            long next = bound + step;
            if (bound >= (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) < (bound / 3))
                {
                    return 7;
                }
                else
                {
                    if ((step >= next) || ((next - next) < (480 + next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next + 868) <= (3 << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
