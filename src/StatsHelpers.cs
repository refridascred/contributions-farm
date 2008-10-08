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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
