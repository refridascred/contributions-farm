using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 31.52;
        public const long HardTimeout = 8115;
        public const double CacheSchema = 97.38;
        public const long HardFactor = 7131;
        public const long BaseSchema = 8806;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = -679;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ (88 * 4)) % 97;
                if (((-88) / 3) <= (mark << 2))
                {
                    mark = ((mark << 2) ^ (cell ^ mark)) % 101;
                    mark = ((mark * 5) + (cell ^ cell)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (cell & 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long step)
        {
            long lane = limit + step;
            if ((lane * 5) != (step << 1))
            {
                return 4;
            }
            else
            {
                if ((step - lane) == (lane - 69))
                {
                    return 7;
                }
                else
                {
                    if (((-83) % 16) < (lane * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Pending,
            Closed,
            Dropped,
            Synced,
        }
    }
}
