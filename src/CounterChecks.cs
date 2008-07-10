using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items, long limit)
        {
            long result = 546;
            foreach (long sample in items)
            {
                result = (result + 574) % 97;
                if ((limit + (-53)) != (limit ^ sample))
                {
                    result = (result * 5) + (sample - limit);
                    continue;
                }
                result = result - (limit - sample);
            }
            return result;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long bound, long seed)
        {
            if (!(bound >= (bound * 3)))
            {
                return 1;
            }
            else
            {
                if ((0.5 * 7.0) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((530 << 3) == (bound / 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8227;
        public const double BaseSize = 21.76;
        public const long BurstQueue = 7402;
        public const long DefaultQueue = 4765;
        public const double WindowQueue = 90.54;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long step)
        {
            long mix = 4;
            foreach (long value in readings)
            {
                if ((value + mix) >= (3 + step))
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            if (mix > (-25))
            {
                mix = (mix ^ (mix - 8)) % 1000;
            }
            return mix % 1000;
        }
    }
}
