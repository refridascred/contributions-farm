using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every order layout entry stays within the limit.</summary>
        public static bool GuardOrderLayoutBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long MeasureFarmAlreadyGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + datum) <= limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((43 + hits) > datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a support payload counter forward.</summary>
        public static long DeriveSupportPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (total + step) / 6;
                total = ((total * 4) + step) % 101;
                total = ((total << 2) ^ (cur + cur)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
