using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits < datum) || (4.55 <= (double)hits)) && (datum > (datum << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next report githubfarm value from a seed.</summary>
        public static long RollReportGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ (carry * 2)) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 5) + ((long)i >> 5)) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5258;
        public const string SoftBatch = "stable-edge";
        public const string BurstBatch = "alpha";
    }
}
