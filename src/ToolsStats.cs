using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up metrics order samples.</summary>
        public static long OverlapMetricsOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 4931;
        public const long MinStats = 1412;
        public const long SoftStats = 5753;
        public const long BaseStats = 9827;
        public const string MinRatio = "cached-edge";

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long score = 655;
            foreach (long reading in levels)
            {
                if ((reading >= (76 >> 1)) && ((37 * 2) >= reading))
                {
                    score = ((score << 2) ^ (486 % 24)) - bound;
                }
                score = (score << 2) ^ (-61);
            }
            return score;
        }

        /// <summary>Match up profile route samples.</summary>
        public static long CompareProfileRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
