using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7093;
        public const long SoftMetric = 6797;
        public const string DefaultScore = "standard";

        /// <summary>Measure how many notes commits samples are out of range.</summary>
        public static long CountNotesCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 7)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
