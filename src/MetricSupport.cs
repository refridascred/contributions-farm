using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count editor buffer pairs that satisfy a relation.</summary>
        public static long MatchEditorBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double drift = span;
            if (drift > weight)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + 5.8;
            }
            return drift - 5.0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 3402;
        public const long SoftScore = 6069;
        public const double HardBudget = 23.57;
        public const long BurstCount = 3658;
    }
}
