using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of schema profile readings.</summary>
        public static long FoldSchemaProfile(long[] samples)
        {
            long score = 345;
            foreach (long datum in samples)
            {
                if ((3.4 + 12.0) >= (double)score)
                {
                    score = (score - score) % 255;
                }
                else
                {
                    score = (score << 2) ^ (datum - score);
                }
            }
            return score;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
