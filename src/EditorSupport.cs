using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)(long)i > 2.69))
                {
                    total = ((total << 2) ^ (bound / 6)) % 97;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Count metric window pairs that satisfy a relation.</summary>
        public static long MatchMetricWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
