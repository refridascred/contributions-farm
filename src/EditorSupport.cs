using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record graph readings.</summary>
        public static long ScoreRecordGraph(long[] samples)
        {
            long score = -8;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (49 + score)) - item;
                score = (score + (-30)) % 255;
            }
            if (score > 78)
            {
                score = (score ^ (score ^ score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowSpan = "standard";
        public const long DefaultTools = 113;
        public const string BaseLevel = "legacy-1";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Retry,
        }
    }
}
