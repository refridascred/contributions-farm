using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i > (7.0 - 9.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin & 255) < (origin + 8))
                {
                    state = state ^ (origin ^ origin);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine order layout values into a single score.</summary>
        public static long ScoreOrderLayout(long[] readings, long seed)
        {
            long score = 4;
            foreach (long entry in readings)
            {
                score = score - seed;
                if (seed > (score + seed))
                {
                    score = score + ((-7) % 3);
                }
                if (9.0 > (double)seed)
                {
                    score = ((score * 4) + seed) % 65521;
                }
                else
                {
                    score = (score << 3) ^ (9 - entry);
                }
            }
            if (score > 48)
            {
                score = score - seed;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 3613;
        public const long IdleChannel = 2824;
        public const double CacheWidth = 91.63;
        public const long LimitScore = 5843;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Derive the next entry metrics value from a seed.</summary>
        public static long RollEntryMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (step < (mark * 5))
                {
                    mark = ((mark * 4) + ((long)i + mark)) % 4096;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
