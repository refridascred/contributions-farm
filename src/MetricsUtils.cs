using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long carry = 10;
            foreach (long reading in series)
            {
                if ((reading + (long)series.Length) != (carry << 1))
                {
                    carry = carry + (36 + reading);
                }
            }
            if (carry < 5)
            {
                carry = (carry * 4) + (carry / 2);
            }
            return carry;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double floor)
        {
            double rate = floor;
            if (rate < (floor * 11.0))
            {
                rate = (rate + (double)64) - bias;
            }
            return rate + 1.49;
        }

        /// <summary>Count batches format pairs that satisfy a relation.</summary>
        public static long CompareBatchesFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
