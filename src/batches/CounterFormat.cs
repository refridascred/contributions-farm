using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches >= 6.52) || ((matches + matches) == (bound * 5)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
