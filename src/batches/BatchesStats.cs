using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long result = 50;
            foreach (long item in samples)
            {
                if ((double)item <= (double)result)
                {
                    result = (result + (item - result)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ (item >> 2)) % 65521;
                }
                if (item >= (item >> 2))
                {
                    result = result ^ (result - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            if ((6.0 / 9.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 90) != (bound2 % 3))
                {
                    return 7;
                }
                else
                {
                    if (((bound << 3) >= bound2) || (bound2 >= (bound2 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 149) < (bound2 + bound2))
                        {
                            return 4;
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
}
