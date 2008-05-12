using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double weight = offset;
            if (weight > (6.0 * 14.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 1.9)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long limit)
        {
            long lane = step ^ limit;
            if ((double)limit == (0.3 * 11.0))
            {
                return 5;
            }
            else
            {
                if (step > (lane + limit))
                {
                    return 6;
                }
                else
                {
                    if ((lane <= (lane << 2)) || ((double)lane <= 2.4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
