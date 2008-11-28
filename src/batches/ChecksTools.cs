using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples)
        {
            long total = -89;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (total & 63)) % 97) ^ value;
            }
            return total % 97;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double load = (double)(257 & 63);
            return (load - span) + gain;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series)
        {
            long acc = 9;
            foreach (long reading in series)
            {
                acc = ((acc * 2) + reading) % 1000;
            }
            if (acc > 71)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
            }
            return acc;
        }
    }
}
