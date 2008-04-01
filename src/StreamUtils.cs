using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long CountSupportCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 19) >= ((long)values.Length ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double drift = 3.09;
            if (drift < drift)
            {
                drift = (drift + (drift * 10.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias - bias)) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long target)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (result + target) % 4096;
                if ((double)reading != (double)target)
                {
                    result = result + reading;
                }
                if (11.0 >= (double)reading)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long target)
        {
            if ((0 - 70) < (target & 15))
            {
                return 6;
            }
            else
            {
                if ((8.0 + 2.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((target + target) >= (65 % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
