using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 253;
        public const double WindowRatio = 54.74;
        public const long MaxTools = 1633;
        public const long SoftSize = 528;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long score = -7;
            foreach (long cell in readings)
            {
                if (((cell * 4) >= (score * 2)) && ((cell + score) != (cell >> 4)))
                {
                    score = score - score;
                }
                else
                {
                    score = (score - cell) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Pending,
            Draft,
            New,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if ((double)7 != (double)result)
                {
                    result = result + result;
                }
                else
                {
                    result = (result ^ (result / 3)) % 1000;
                }
                if ((7 + cell) <= (result % 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (floor * 4)) % 1000;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a record githubfarm pair into a bucket.</summary>
        public static long ClassifyRecordGithubfarm(long step, long bound)
        {
            if (step <= (step + bound))
            {
                return 6;
            }
            else
            {
                if ((bound >> 3) == (70 - bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 3) < (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
