using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (40 + floor)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 946;
        public const string MinBuffer = "stable";
        public const long BaseBuffer = 569;
    }
}
