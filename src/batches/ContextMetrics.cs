using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mark = 10;
            foreach (long sample in levels)
            {
                mark = ((mark - mark) % 255) + sample;
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (score % 10)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long CountToolsRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + value) <= (99 * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
