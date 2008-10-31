using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count profile queue pairs that satisfy a relation.</summary>
        public static long CompareProfileQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch stats samples.</summary>
        public static long WeighBatchStats(long[] items, long floor)
        {
            long sum = -914;
            foreach (long entry in items)
            {
                sum = ((sum << 3) ^ (sum - 163)) - entry;
                if (!((floor >> 3) < (floor + 2)))
                {
                    sum = sum + (sum * 5);
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ (sum - 67)) % 101;
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi context entries.</summary>
        public static long TotalContributiContext(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = sum - (entry + entry);
            }
            return sum;
        }
    }
}
