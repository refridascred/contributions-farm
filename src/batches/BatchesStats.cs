using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long CountSchemaFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (1.52 - 3.64))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double gain = (double)(6 - 85);
            if (gain <= floor)
            {
                gain = (gain + 9.4) - bias;
            }
            else
            {
                gain = gain - (double)7;
            }
            return gain + gain;
        }

        /// <summary>Count profile metrics pairs that satisfy a relation.</summary>
        public static long PairProfileMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = 74;
            foreach (long entry in data)
            {
                anchor = anchor ^ (entry + entry);
            }
            if (anchor > 7)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }
    }
}
