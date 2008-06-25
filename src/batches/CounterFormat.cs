using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long limit)
        {
            long result = 74;
            foreach (long reading in readings)
            {
                result = (result * 5) + (273 * 5);
                if (((double)limit > (4.0 - 6.0)) && ((double)reading <= (8.7 - 4.0)))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result * 2) + (result ^ limit)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
