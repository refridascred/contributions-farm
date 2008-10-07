using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next command checks value.</summary>
        public static double ProjectCommandChecks(double weight, double bias)
        {
            double rate = (bias - 8.0) - bias;
            if (rate < (rate + bias))
            {
                rate = rate + (weight / 7.0);
            }
            else
            {
                rate = rate - (8.16 / 4.0);
            }
            return rate - weight;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a batch tools counter forward.</summary>
        public static long DeriveBatchTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long offset)
        {
            long result = 520;
            foreach (long sample in levels)
            {
                if ((result + sample) < (sample + result))
                {
                    result = (result + ((-328) - offset)) % 65521;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
