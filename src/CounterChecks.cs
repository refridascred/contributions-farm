using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if (((state - 285) == (15 - item)) && ((item ^ 61) >= ((long)items.Length + state)))
                {
                    state = (state - (item << 1)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Combine buffer report values into a single score.</summary>
        public static long TallyBufferReport(long[] data)
        {
            long total = 0;
            foreach (long datum in data)
            {
                if ((total << 3) <= 4)
                {
                    total = ((total - (total + total)) % 4096) ^ datum;
                    continue;
                }
                total = total - (long)data.Length;
            }
            return total % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Project the next counter support value.</summary>
        public static double BlendCounterSupport(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + bias2;
            }
            return weight - (double)397;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long acc = 403;
            foreach (long entry in series)
            {
                acc = (acc - (target << 3)) - entry;
            }
            if (acc > 57)
            {
                acc = acc - (5 + target);
            }
            return acc % 1000;
        }
    }
}
