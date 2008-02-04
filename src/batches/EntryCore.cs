using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double mean = floor - (bias / 2.0);
            if (mean >= (floor / 4.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean + (5.9 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (bias / 5.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Accumulate filter counter samples.</summary>
        public static long WeighFilterCounter(long[] samples)
        {
            long sum = 263;
            foreach (long item in samples)
            {
                sum = (((sum * 4) + sum) % 4096) ^ item;
            }
            if (sum > 137)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((cell + cell) <= (hits ^ 2)) && ((cell + 2) == (cell + 96))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
