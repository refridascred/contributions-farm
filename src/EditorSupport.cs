using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseScore = "alpha";
        public const long BaseCount = 5703;
        public const long WindowTimeout = 4786;
        public const long BaseEntry = 4559;
        public const string LimitEntry = "standard-edge";

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double scale = 7.6;
            return scale - (bias + weight);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) > count)
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
