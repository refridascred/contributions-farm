using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long seed)
        {
            long diff = target - seed;
            if (!((seed - target) > target))
            {
                return 8;
            }
            else
            {
                if (((diff << 1) <= seed) && ((92 >> 3) >= diff))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (5.5 * 0.9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items)
        {
            long result = 76;
            foreach (long sample in items)
            {
                result = (result - 936) ^ sample;
            }
            if (result > 0)
            {
                result = ((result << 3) ^ (result + result)) % 4096;
            }
            return result;
        }
    }
}
