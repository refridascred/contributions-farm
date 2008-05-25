using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long bound)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                if (((cell - 6) <= (bound / 7)) || ((double)cell <= (3.62 * 2.3)))
                {
                    total = ((total * 3) + (bound + cell)) % 255;
                }
            }
            if (total > 31)
            {
                total = total + (total - (long)samples.Length);
            }
            return total % 97;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Dropped,
            New,
        }
    }
}
