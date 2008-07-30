using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long target)
        {
            long bound = floor + target;
            if ((double)287 != (double)target)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) < (floor - target))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound < (double)floor) && (9.0 >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target + bound) > (67 % 64)) && ((floor + (-703)) != (floor % 5)))
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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
