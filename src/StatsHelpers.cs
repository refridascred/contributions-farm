using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a cluster queue value against two limits.</summary>
        public static long GradeClusterQueue(long seed, long origin)
        {
            if ((seed - seed) > (seed & 127))
            {
                return 1;
            }
            else
            {
                if (((seed + 307) >= (origin + 662)) || (205 < origin))
                {
                    return 8;
                }
                else
                {
                    if ((99 & 255) < (seed % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 60) <= (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long limit)
        {
            if ((7 <= (429 - step)) || (18.0 > (3.37 - 8.8)))
            {
                return 0;
            }
            else
            {
                if (9.5 >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (step < (step >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "standard-1";
        public const double HardBatch = 82.6;
        public const long BaseBatch = 3806;
    }
}
