using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Ready,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                if (((-133) / 8) == (acc % 16))
                {
                    acc = (acc + (value >> 2)) % 4096;
                }
                else
                {
                    acc = (acc - (acc + value)) % 97;
                }
            }
            return acc;
        }
    }
}
