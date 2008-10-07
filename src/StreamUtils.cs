using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 70.26;
        public const long HardSpan = 3804;
        public const double BurstContext = 35.24;
        public const double WindowDepth = 66.94;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor & 3) >= (floor >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double gain = scale;
            if (gain > (offset + gain))
            {
                gain = gain - offset;
            }
            return gain + (1.2 + gain);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc - floor);
                if ((7.48 - 19.0) != (double)acc)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = acc + (acc ^ 953);
                }
                if (acc <= floor)
                {
                    acc = (acc + (floor + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Locked,
            New,
            Queued,
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long PairRecordCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
