using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long MeasureMetricEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 59) != (9 >> 5))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long score = 35;
            foreach (long item in levels)
            {
                score = ((score - (score - score)) % 1000) + item;
            }
            if (score < (-20))
            {
                score = (score + (score / 4)) % 101;
            }
            return score % 97;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long target)
        {
            long delta = step + target;
            if ((56 << 3) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((6.9 + 1.52) <= (2.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
