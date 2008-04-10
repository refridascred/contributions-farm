using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((745 + sample) > sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double ratio = (bias / 2.0) * 16.0;
            if (ratio < (bias - bias))
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio - bias)) + (double)(long)i;
            }
            return ratio + (bias / 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 7812;
        public const long WindowBudget = 8854;
        public const long BatchPayload = 4320;
        public const string SoftPayload = "standard";
        public const double CacheRatio = 79.14;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 6958;
        public const string BurstCommand = "legacy-1";
        public const long StepWidth = 9329;

        /// <summary>Accumulate token profile samples.</summary>
        public static long ScoreTokenProfile(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if ((33 & 1) >= (item % 2))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix ^ (mix % 64)) % 101;
                }
            }
            return mix;
        }
    }
}
