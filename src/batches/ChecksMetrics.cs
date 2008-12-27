using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "cached";
        public const double StepToken = 68.57;
        public const string BatchDepth = "fallback-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long seed)
        {
            if ((step - 6) >= seed)
            {
                return 4;
            }
            else
            {
                if ((double)232 != (double)step)
                {
                    return 5;
                }
                else
                {
                    if (!((double)step > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 3067;
        public const long StepScore = 7866;
        public const long IdleCount = 604;
        public const long MinSpan = 6864;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2585;
        public const double RetryEntry = 34.86;
        public const long MinScore = 9733;
        public const long SoftTimeout = 5191;
    }
}
