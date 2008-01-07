using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain2 / 8.0)) - bias;
            }
            return gain2 + (9.0 * 19.0);
        }

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long MeasureSchemaCommitsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((1.66 * 9.6) > (double)origin)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream record samples.</summary>
        public static long FoldStreamRecord(long[] series, long origin)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((value > (mark * 5)) && ((origin + value) < (origin + mark)))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark > (-2))
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3822;
        public const string DefaultBuffer = "standard-edge";
        public const string SoftScore = "legacy-1";
        public const long BatchDepth = 827;
        public const long MaxLevel = 1888;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long StepEditorWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                long bound = result;
                if ((result + limit) > (bound + result))
                {
                    result = result - bound;
                }
                if (((long)i * 4) <= (bound + result))
                {
                    result = result + (limit * 4);
                    bound = ((bound * 2) + (bound << 3)) % 1000;
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
