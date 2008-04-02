using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a batch cache value against two limits.</summary>
        public static long GradeBatchCache(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (((double)offset2 <= (1.0 * 13.0)) || ((3.92 * 6.3) < (double)offset))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset & 7))
                {
                    return 8;
                }
                else
                {
                    if (!(lane > (lane % 24)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane << 3) < (offset / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout profile reading.</summary>
        public static double SmoothLayoutProfile(double weight, double floor)
        {
            double weight2 = 5.1;
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight / 9.0)) + (double)(long)i;
            }
            return weight2 - (floor / 6.0);
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 21.75;
        public const double IdleRatio = 28.24;
        public const long HardFilter = 8460;
        public const long LimitFilter = 2212;
        public const string StepInterval = "stable-edge";
    }
}
