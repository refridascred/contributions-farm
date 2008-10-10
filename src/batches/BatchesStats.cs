using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 8824;
        public const double BurstSpan = 84.41;
        public const long BatchCount = 1315;
        public const string RetryBatch = "stable";

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double load = (double)(0 - (-48));
            if (load <= (double)7)
            {
                load = (load - offset) + weight;
            }
            return load + (19.0 - 13.0);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            if ((double)seed <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((seed << 1) != (3 << 1)) && ((bound * 3) > (bound + bound)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count editor tools pairs that satisfy a relation.</summary>
        public static long CompareEditorToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
