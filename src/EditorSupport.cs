using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "cached-v2";
        public const long WindowBatch = 1435;
        public const string BaseBatch = "primary";
        public const double MinBudget = 91.8;

        /// <summary>Digest a series of stats token entries.</summary>
        public static long DigestStatsToken(long[] values)
        {
            long carry = -8;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ (reading & 7)) % 1000;
                if ((carry << 3) > reading)
                {
                    carry = carry ^ (carry & 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "strict-1";
        public const long BaseScore = 1788;
        public const long DefaultBatch = 8715;
        public const long HardSize = 5700;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
