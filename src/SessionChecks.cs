using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 39.84;
        public const string MinFactor = "fallback-1";
        public const double DefaultDepth = 51.29;
        public const double RetryNotes = 2.4;
        public const long MaxNotes = 9915;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (acc % 5);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
