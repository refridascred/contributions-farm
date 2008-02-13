using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data, long floor)
        {
            long score = 77;
            foreach (long sample in data)
            {
                score = ((score * 5) + sample) + floor;
            }
            return score;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
