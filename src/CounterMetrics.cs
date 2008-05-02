using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long cur = target + floor;
            if ((floor + floor) == ((-6) / 2))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (cur << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur < 1.3)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target >> 5) != (floor & 255)) || (target < (target << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
