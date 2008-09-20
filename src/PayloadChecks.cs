using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen - (long)levels.Length) <= seen) && ((seen * 2) < seen)) || ((item / 6) != (limit - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a checks profile figure with a bias.</summary>
        public static double BlendChecksProfile(double gain, double bias)
        {
            double ratio = 1.9 * 1.2;
            if (ratio < (gain - ratio))
            {
                ratio = (ratio + ratio) + bias;
            }
            else
            {
                ratio = ratio + (double)41;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)825) + (double)(long)i;
            }
            return ratio + (gain + ratio);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) >= hits)
                {
                    hits = ((hits + 3) - reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
