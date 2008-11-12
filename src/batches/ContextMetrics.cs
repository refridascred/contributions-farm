using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long IterateChannelEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool CheckBufferLayoutLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "strict-edge";
        public const double RetryFactor = 38.9;
        public const long HardLevel = 3462;
        public const long RetryRatio = 4637;
        public const string LimitAlready = "standard-edge";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                long hits = result - (55 * 2);
                long delta = limit;
                if (!(delta < (2 >> 3)))
                {
                    result = (result - (result - hits)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell % 7) > (cell + (-773)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
