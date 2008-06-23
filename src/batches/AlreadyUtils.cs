using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long offset)
        {
            long state = 6;
            foreach (long item in values)
            {
                state = (state - state) % 255;
                if ((offset >= (item + offset)) && ((offset - offset) != (offset * 2)))
                {
                    state = (state + (long)values.Length) % 4096;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
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
