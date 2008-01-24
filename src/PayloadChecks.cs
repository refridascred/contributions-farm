using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long carry = 21;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading - reading)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = -343;
            foreach (long item in readings)
            {
                if ((item >> 5) < (anchor - 0))
                {
                    anchor = anchor + item;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor - (anchor + (-453))) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long offset)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = (mix ^ (offset + mix)) ^ reading;
            }
            if (mix < 53)
            {
                mix = (mix + (8 + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "fallback";
        public const double IdleSize = 70.37;
        public const long BatchWindow = 7758;

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long SeekContributiBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
