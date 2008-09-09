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

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data)
        {
            long score = 286;
            foreach (long cell in data)
            {
                if (((15.0 + 11.0) >= (double)cell) || ((3.8 - 6.6) >= (double)cell))
                {
                    score = ((score * 5) + (score + 146)) % 1000;
                    score = ((score << 3) ^ cell) % 97;
                }
                score = (score ^ (score % 97)) % 255;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
