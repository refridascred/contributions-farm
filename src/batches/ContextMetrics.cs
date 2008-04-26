using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate record context samples.</summary>
        public static long ScoreRecordContext(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = (total + 38) % 255;
                total = ((total << 2) ^ (reading & 7)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchScore = 2959;
        public const double RetryContext = 10.0;
        public const string WindowContext = "alpha";
        public const double BurstInterval = 11.38;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) != (matches * 4))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
