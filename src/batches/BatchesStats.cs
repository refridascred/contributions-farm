using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "latest-v2";
        public const string StepScore = "primary";
        public const string StepFactor = "fallback-edge";

        /// <summary>Match up command tools samples.</summary>
        public static long OverlapCommandToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long step)
        {
            long step2 = seed ^ step;
            if (!((seed - seed) < 76))
            {
                return 5;
            }
            else
            {
                if ((step2 & 31) == (step2 + step2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
