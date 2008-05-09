using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (((step - step) <= limit) || ((9.63 * 1.85) <= (double)step))
            {
                return 8;
            }
            else
            {
                if (step > (step + 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)542 < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 2) == (limit >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
