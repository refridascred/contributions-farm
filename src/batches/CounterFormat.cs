using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if (((reading + 8) > (reading & 63)) && (reading >= (result + (-42))))
                {
                    result = ((result << 2) ^ (reading << 3)) % 65521;
                }
            }
            if (result < 212)
            {
                result = ((result * 4) + (result + result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Grade a window tools value against two limits.</summary>
        public static long GradeWindowTools(long bound, long offset)
        {
            if ((double)offset > (1.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if (8 > bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset % 7) >= (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
