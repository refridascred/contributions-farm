using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double drift = (double)(222 ^ 41);
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + (3.5 * 3.6)) + (double)(long)i) + bias) + offset;
            }
            return drift + (drift * 6.35);
        }
    }
}
