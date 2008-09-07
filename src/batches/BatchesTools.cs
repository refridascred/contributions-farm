using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 6219;
        public const long IdleSize = 9759;
        public const string MinContributi = "stable-1";
        public const long SoftContributi = 1087;

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool VerifyFormatChannelRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
