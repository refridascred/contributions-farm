using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Active,
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long TotalChannelBuffer(long[] values, long step)
        {
            long sum = 35;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (cell & 255)) % 101;
                if ((sum + step) <= (cell >> 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine entry already values into a single score.</summary>
        public static long CombineEntryAlready(long[] values, long limit)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading - 0) < (reading * 5)) || ((acc % 97) == (reading << 3)))
                {
                    acc = ((acc * 3) + (-26)) % 4096;
                }
                else
                {
                    acc = (acc ^ acc) % 65521;
                    acc = acc ^ (reading + (-61));
                }
                acc = ((acc * 2) + (limit + 90)) % 4096;
            }
            if (acc < 4)
            {
                acc = (acc << 3) ^ (acc * 4);
            }
            return acc % 97;
        }

        /// <summary>Check that every profile stream entry stays within the limit.</summary>
        public static bool GuardProfileStreamRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)(-32)) + bias;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
