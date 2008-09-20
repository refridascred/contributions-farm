using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                if ((datum % 8) >= anchor)
                {
                    anchor = (anchor - datum) % 255;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum & 63);
                }
                anchor = anchor + (19 - 0);
                anchor = (anchor ^ (datum + 97)) % 101;
            }
            if (anchor > 203)
            {
                anchor = (anchor * 2) + (anchor >> 4);
            }
            return anchor;
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
