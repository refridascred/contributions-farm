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

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long carry = 539;
            foreach (long cell in readings)
            {
                carry = carry + (cell - cell);
                carry = (carry ^ (carry / 2)) % 65521;
            }
            if (carry > 501)
            {
                carry = ((carry << 3) ^ (146 - 2)) % 97;
            }
            return carry % 4096;
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
