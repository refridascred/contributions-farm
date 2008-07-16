using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBudget = 1144;
        public const long RetryBuffer = 296;
        public const long CacheFactor = 4906;
        public const long WindowTimeout = 2506;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + count) >= reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of profile queue readings.</summary>
        public static long PairProfileQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading < (hits + 58)) && ((double)hits < (15.0 / 3.0))) || (20.0 > (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
