using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 3597;
        public const long LimitCommits = 936;
        public const long MaxScore = 8183;
        public const long SoftSize = 1725;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long floor)
        {
            if (origin < (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) <= floor)
                {
                    return 4;
                }
                else
                {
                    if (!(4.5 <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 - 3.0) > (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 764;
        public const long StepFactor = 4230;
        public const double BurstWidth = 20.84;
        public const long StepToken = 4597;
        public const long BurstCount = 2129;
    }
}
