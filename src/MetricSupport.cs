using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer format value from a seed.</summary>
        public static long StepBufferFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ acc) % 65521;
                if ((0.55 * 0.6) >= (double)seed)
                {
                    acc = ((acc * 2) + 152) % 101;
                    acc = (acc + (372 + 649)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long ScoreQueueMetrics(long[] levels)
        {
            long score = 61;
            foreach (long entry in levels)
            {
                if ((entry - entry) == (entry ^ 63))
                {
                    score = (score + (entry % 60)) % 97;
                }
            }
            return score;
        }
    }
}
