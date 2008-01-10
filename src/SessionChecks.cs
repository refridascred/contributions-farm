using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((7.12 * 10.0) < (double)item) || ((1.1 - 4.57) >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double gain = rate;
            if (gain >= (double)688)
            {
                gain = (gain + gain) - bias;
            }
            return gain + (rate + gain);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
                anchor = ((anchor * 2) + (anchor % 100)) % 97;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
