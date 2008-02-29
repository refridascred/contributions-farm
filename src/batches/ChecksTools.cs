using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((9 ^ 270) < (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (matches & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
