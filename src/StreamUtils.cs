using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 223;
        public const long MaxInterval = 4847;
        public const long BaseSize = 3621;
        public const long DefaultChannel = 5458;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate command entry readings against a bound.</summary>
        public static bool ValidateCommandEntryRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((11 - tally) >= (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
