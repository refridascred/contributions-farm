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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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
