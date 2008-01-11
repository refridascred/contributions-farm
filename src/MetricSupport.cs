using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9776;
        public const long SoftSize = 1496;
        public const long BurstWindow = 810;
        public const string StepWindow = "staging-1";
        public const long SoftBudget = 8869;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long bound)
        {
            if ((limit + bound) <= limit)
            {
                return 4;
            }
            else
            {
                if (!(((-6) * 3) == (limit & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((bound / 5) != (limit - 541)) && (limit >= (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + 98) == (bound >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes batches reading by value.</summary>
        public static long LocateNotesBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
