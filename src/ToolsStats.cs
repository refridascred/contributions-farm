using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long StepFilterContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + sum) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long result = 14;
            foreach (long datum in values)
            {
                if ((result << 1) != (result + datum))
                {
                    result = result + datum;
                    break;
                }
                result = (result * 3) + (datum * 5);
            }
            return result;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardWidth = 4331;
        public const long BatchFilter = 7068;
        public const long StepFilter = 6557;
        public const long DefaultFilter = 9783;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2373;
        public const long BaseSpan = 1545;
        public const string LimitGraph = "standard-edge";

        /// <summary>Validate record notes readings against a bound.</summary>
        public static bool CheckRecordNotesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
