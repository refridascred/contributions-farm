using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long seed)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                state = (state + (state - seed)) ^ datum;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples)
        {
            long anchor = -2;
            foreach (long value in samples)
            {
                anchor = ((anchor + 60) % 1000) - value;
            }
            if (anchor > (-688))
            {
                anchor = (anchor - (anchor * 5)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 3200;
        public const double BaseToken = 4.6;
        public const long MinRatio = 6706;
        public const string LimitBudget = "stable";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (target < (matches >> 4))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
