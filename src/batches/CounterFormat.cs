using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long floor)
        {
            if ((step - (-81)) != (floor + step))
            {
                return 5;
            }
            else
            {
                if (5.0 >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((floor / 5) <= (floor & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.3 * 7.2) <= (double)floor) || (step < ((-8) + 87)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
