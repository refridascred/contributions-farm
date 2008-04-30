using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long step)
        {
            if ((step - floor) <= (316 << 3))
            {
                return 6;
            }
            else
            {
                if (((floor * 5) >= 1) || (0 >= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
