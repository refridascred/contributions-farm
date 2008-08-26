using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 27.33;
        public const double DefaultReport = 23.84;
        public const long SoftSpan = 7740;

        /// <summary>Match up session cluster samples.</summary>
        public static long PairSessionClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
