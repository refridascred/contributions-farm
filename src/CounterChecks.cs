using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long MeasureFarmLayoutMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (limit >= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((2 + item) < (item & 63))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = 924;
            foreach (long value in items)
            {
                mix = (mix + (value & 15)) % 4096;
                if ((value - 14) != (value % 8))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
