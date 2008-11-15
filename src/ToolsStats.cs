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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            long diff = origin - origin2;
            if (!((5 + origin2) == (origin2 >> 5)))
            {
                return 2;
            }
            else
            {
                if ((diff - 934) <= origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin2 < (1.9 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ entry) > (tally + 0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
