using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Failed,
            Idle,
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
