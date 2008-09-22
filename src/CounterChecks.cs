using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command queue sample.</summary>
        public static long SeekCommandQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Roll a batches graph counter forward.</summary>
        public static long StepBatchesGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (state & 7);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((floor & 63) >= (229 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (8 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (6.0 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 8) != (floor + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long MeasureSupportEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((-4) & 1) > (matches / 4))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
