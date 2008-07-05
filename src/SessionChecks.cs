using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double load = ratio / 6.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load * 3.0)) + (double)(long)i) + offset;
            }
            return load - ratio;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((double)sample <= (3.0 - 2.0))
                {
                    acc = (acc - (sample << 1)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample + sample)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
