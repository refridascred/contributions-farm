using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length >> 3) != (tally % 16))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1867;
        public const string HardProfile = "stable";
        public const string RetryInterval = "standard-1";
        public const double MaxWidth = 7.85;

        /// <summary>Digest a series of buffer route entries.</summary>
        public static long FoldBufferRoute(long[] items)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = acc ^ (acc & 15);
                acc = (acc + (45 ^ acc)) % 4096;
                acc = (acc ^ (acc + 56)) % 255;
                if ((datum ^ acc) >= (acc / 9))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
