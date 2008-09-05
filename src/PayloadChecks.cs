using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((long)values.Length >= (4 << 1))
                {
                    tally = ((tally + 1) + item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "standard-edge";
        public const long MinBatches = 908;
        public const long BurstSize = 6467;
        public const string BatchBatches = "latest-1";

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
