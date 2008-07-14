using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long total = 988;
            foreach (long cell in readings)
            {
                total = ((((total * 4) + (5 % 97)) % 97) + cell) + step;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 49.65;
        public const long DefaultSize = 4942;
        public const double DefaultReport = 96.21;
        public const double BaseCount = 4.96;
        public const long RetryReport = 3112;
    }
}
