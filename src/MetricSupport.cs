using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = (load - scale) - bias;
            }
            return load - scale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Pending,
            Stale,
            Dropped,
        }
    }
}
