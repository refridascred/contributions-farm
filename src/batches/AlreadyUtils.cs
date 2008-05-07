using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count report cache pairs that satisfy a relation.</summary>
        public static long OverlapReportCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                if (8.0 > (double)limit)
                {
                    sum = (sum - reading) % 65521;
                }
                if ((878 + sum) <= (sum + reading))
                {
                    sum = (sum + (limit + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long bound)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = (score + value) + bound;
            }
            return score % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
