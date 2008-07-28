using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset + value) > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the account order series from a seed.</summary>
        public static long DeriveAccountOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target / 8) < (result / 8))
                {
                    result = ((result << 3) ^ (result - (long)i)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long CountSessionEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
