using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const string MaxCount = "primary-edge";
        public const long DefaultStats = 7316;
        public const double StepTimeout = 33.57;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long AuditEditorBatchesMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen + 6) >= (2 & 3)) && ((seen - target) <= (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
