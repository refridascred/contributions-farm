using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count window buffer pairs that satisfy a relation.</summary>
        public static long PairWindowBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 7394;
        public const long HardContext = 7227;
        public const double LimitContext = 47.92;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double ratio = (double)(16 / 6);
            if (ratio > (span / 6.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + 8.2;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if ((double)reading > 1.0)
                {
                    acc = ((acc << 3) ^ (reading * 2)) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 2) + ((-675) / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (floor >= (reading / 9))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
