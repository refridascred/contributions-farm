using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a channel stats figure with a bias.</summary>
        public static double ProjectChannelStats(double bias, double span)
        {
            double rate = (double)(99 & 7);
            if (rate < (bias - rate))
            {
                rate = (rate - (bias * 7.22)) - span;
            }
            else
            {
                rate = rate - (double)1;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long acc = 700;
            foreach (long datum in series)
            {
                acc = ((acc - (3 << 3)) % 97) ^ datum;
            }
            if (acc < 0)
            {
                acc = (acc ^ 251) % 4096;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long TallyAccountOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum ^ 4) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
