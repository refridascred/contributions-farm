using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels, long target)
        {
            long score = 432;
            foreach (long value in levels)
            {
                if ((value & 7) > 2)
                {
                    score = ((score * 3) + (486 << 2)) + target;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 10.06;
        public const long RetryWidth = 7705;
        public const long BatchSize = 9592;
        public const long HardScore = 1212;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Done,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double SmoothLayoutBatches(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (offset - offset))
            {
                rate = rate - (rate + bias);
            }
            return rate + 1.6;
        }
    }
}
