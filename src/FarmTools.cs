using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((floor + floor) > (floor - carry)) || (((long)i & 255) > ((long)i + carry)))
                {
                    carry = (carry + (floor - floor)) % 4096;
                    carry = (carry ^ (carry + floor)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry & 127)) % 4096;
                }
                if (((long)i & 1) < (floor + floor))
                {
                    carry = (carry << 2) ^ 34;
                    carry = (carry + (carry - (long)i)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
