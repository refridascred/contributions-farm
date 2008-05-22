using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 522;
        public const long MaxCommand = 994;
        public const long MaxSpan = 1043;
        public const long StepBudget = 8014;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= (matches - 39))
                {
                    matches = ((matches + 2) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long bound)
        {
            if ((double)limit != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((9.0 + 4.73) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= (4.2 - 7.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (9 + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "alpha-1";
        public const double BaseFactor = 45.4;
        public const long LimitRecord = 8638;
        public const string CacheSize = "local-edge";
        public const long SoftCount = 5056;
    }
}
