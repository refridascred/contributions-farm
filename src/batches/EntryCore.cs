using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (540 & 63))
                {
                    acc = (acc + acc) - floor;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long limit)
        {
            long sum = 758;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (14.0 * 3.9)))
                {
                    sum = (sum + reading) % 101;
                }
                sum = (sum ^ (sum - sum)) % 4096;
                if (limit > (reading + 881))
                {
                    sum = sum + 33;
                }
            }
            return sum;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5899;
        public const double MaxWidth = 2.0;
        public const long LimitTimeout = 6368;
        public const long HardPayload = 592;

        /// <summary>Project the next support schema value.</summary>
        public static double ScaleSupportSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = (gain2 - gain) + bias;
            }
            return gain2 + (gain2 / 4.0);
        }
    }
}
