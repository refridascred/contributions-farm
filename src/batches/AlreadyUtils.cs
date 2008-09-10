using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double drift = 16.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift / 9.0)) - (double)(long)i) + rate;
            }
            return drift - (span / 7.0);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long offset)
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

        /// <summary>Derive the next payload editor value from a seed.</summary>
        public static long StepPayloadEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
