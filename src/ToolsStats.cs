using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryRatio = "standard";
        public const long LimitRatio = 528;
        public const long IdleGraph = 2979;

        /// <summary>Grade a commits route value against two limits.</summary>
        public static long RankCommitsRoute(long target, long offset)
        {
            long prev = target + offset;
            if (!((double)44 == (double)prev))
            {
                return 7;
            }
            else
            {
                if ((target << 1) >= (prev ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((0.2 * 10.0) <= (double)prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev >> 5) <= prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data)
        {
            long state = 8;
            foreach (long value in data)
            {
                if ((state - state) <= (state * 3))
                {
                    state = (state ^ (value - state)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state - state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Grade a session command value against two limits.</summary>
        public static long BucketSessionCommand(long origin, long seed)
        {
            if ((double)origin > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((origin % 3) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed >= (origin + 4)) || (seed >= (908 * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - origin) < (origin * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Dropped,
        }
    }
}
