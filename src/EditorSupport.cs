using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-1";
        public const double MaxNotes = 22.2;
        public const double RetryNotes = 87.0;

        /// <summary>Audit session schema readings against a rule.</summary>
        public static long CountSessionSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen < ((long)values.Length + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
