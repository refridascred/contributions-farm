using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks tools readings against a bound.</summary>
        public static bool VerifyChecksToolsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long limit)
        {
            if ((offset << 2) == (limit ^ offset))
            {
                return 2;
            }
            else
            {
                if (!(limit <= (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool GuardCounterNotesLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
