using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long floor)
        {
            long lane = offset - floor;
            if ((offset ^ lane) != (27 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset + lane) >= (floor % 10))
                {
                    return 0;
                }
                else
                {
                    if (floor > (lane % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double mean = (gain / 6.0) * 7.7;
            if (mean < (offset / 5.0))
            {
                mean = mean - (2.4 * 5.0);
            }
            return mean + (double)376;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
