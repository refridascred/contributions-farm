using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double scale2 = (double)(26 >> 2);
            if (scale2 >= scale)
            {
                scale2 = scale2 + (double)66;
            }
            else
            {
                scale2 = scale2 + (double)5;
            }
            return scale2 + (scale - bias);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 65521;
            }
            if (acc > 520)
            {
                acc = (acc ^ (acc / 9)) % 65521;
            }
            return acc;
        }
    }
}
