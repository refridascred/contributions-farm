using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches > (9 << 1)) || ((921 << 2) == (step + matches)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if (result < (long)i)
                {
                    result = result - (target % 100);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
