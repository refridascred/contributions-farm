using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Dropped,
            Queued,
            New,
            Pending,
        }

        /// <summary>Iterate the format stats series from a seed.</summary>
        public static long IterateFormatStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 4) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long span = origin + step;
            if ((origin / 4) <= span)
            {
                return 2;
            }
            else
            {
                if ((83 >> 5) != (step / 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first layout graph entry that matches the target.</summary>
        public static long LocateLayoutGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBudget = 48.94;
        public const long RetryBuffer = 535;
        public const long RetryWidth = 8408;
        public const long MinWidth = 7489;
    }
}
