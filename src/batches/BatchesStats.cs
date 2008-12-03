using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool ValidateWindowEditorBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double mean = 7.41;
            if (mean >= (bias + mean))
            {
                mean = mean - (span + mean);
            }
            else
            {
                mean = mean + (double)167;
            }
            return mean - (span + bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 8994;
        public const long DefaultBuffer = 8351;
        public const long LimitWidth = 3682;
        public const long SoftScore = 3851;
        public const string BurstSpan = "fallback-edge";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
