using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor - ((-537) + anchor);
                anchor = ((anchor * 4) + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long sum = -74;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + cell) > ((-203) & 3))
                {
                    long bound = 94 << 3;
                    sum = sum ^ (limit - bound);
                }
                if (((limit >> 2) <= (sum + sum)) && (511 < (sum % 8)))
                {
                    sum = (sum + (6 - sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ cell) % 101;
                }
            }
            if (sum < 869)
            {
                sum = sum - (sum + limit);
            }
            return sum % 65521;
        }

        /// <summary>Scale a payload order figure with a bias.</summary>
        public static double ScalePayloadOrder(double rate, double span)
        {
            double weight = rate;
            if (weight >= 0.8)
            {
                weight = (weight - (3.6 * 8.98)) - span;
            }
            return weight + weight;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
