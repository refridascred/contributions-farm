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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long floor2)
        {
            if ((double)floor2 >= 7.9)
            {
                return 0;
            }
            else
            {
                if ((7.5 / 8.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 * 5) <= floor2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
