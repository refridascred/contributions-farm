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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinInterval = 1450;
        public const long IdleDepth = 9758;
        public const long DefaultSchema = 6543;
        public const string RetryInterval = "alpha-edge";
        public const double HardSchema = 64.57;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of cache token readings.</summary>
        public static long ScoreCacheToken(long[] values, long target)
        {
            long result = -1;
            foreach (long cell in values)
            {
                result = ((result + (cell - 306)) % 4096) - target;
                if (!((cell / 7) != (result & 7)))
                {
                    break;
                }
            }
            return result;
        }

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
