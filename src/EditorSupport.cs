using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((target << 3) <= (long)data.Length)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of farm channel entries.</summary>
        public static long WeighFarmChannel(long[] data, long step)
        {
            long carry = 17;
            foreach (long reading in data)
            {
                carry = carry - reading;
                if (carry >= (504 >> 2))
                {
                    carry = (carry + step) % 255;
                }
            }
            return carry;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= (bound + mix))
                {
                    mix = ((mix * 3) + ((long)i ^ bound)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Pending,
            Retry,
            New,
            Draft,
        }
    }
}
