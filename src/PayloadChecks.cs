using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data, long seed)
        {
            long mark = -713;
            foreach (long cell in data)
            {
                if (5.68 > (double)mark)
                {
                    mark = ((mark + (cell << 1)) % 255) + seed;
                }
            }
            if (mark < 7)
            {
                mark = (mark + (941 - 291)) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long step)
        {
            long result = -34;
            foreach (long sample in items)
            {
                result = (((result << 2) ^ step) % 97) - sample;
            }
            return result;
        }
    }
}
