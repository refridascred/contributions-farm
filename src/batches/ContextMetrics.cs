using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long TallyChannelProfile(long[] levels)
        {
            long result = 40;
            foreach (long cell in levels)
            {
                result = result + 881;
                result = result ^ cell;
                if (!((cell & 63) >= result))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double load = (double)59 * 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load * 2.7)) + (double)(long)i) - floor;
            }
            return load - bias;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels, long floor)
        {
            long mark = 96;
            foreach (long item in levels)
            {
                mark = (mark + (item / 3)) - floor;
            }
            if (mark > (-8))
            {
                mark = ((mark << 2) ^ 544) % 65521;
            }
            return mark;
        }
    }
}
