using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account checks readings against a rule.</summary>
        public static long MeasureAccountChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((0 + matches) >= (step % 60))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits cache readings.</summary>
        public static long OverlapCommitsCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double drift = (double)(786 >> 4);
            if (drift < (bias / 2.0))
            {
                drift = (drift - bias) - span;
            }
            return drift - (double)34;
        }
    }
}
