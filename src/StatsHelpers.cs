using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine cluster account values into a single score.</summary>
        public static long DigestClusterAccount(long[] data, long bound)
        {
            long sum = 85;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ (bound + sum)) ^ reading;
                if (!(sum <= (sum & 63)))
                {
                    break;
                }
            }
            if (sum < (-5))
            {
                sum = (sum + (sum * 3)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long ClassifyBufferCommand(long offset, long seed)
        {
            if ((seed << 1) == (offset + 16))
            {
                return 8;
            }
            else
            {
                if (!((seed + offset) > 34))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset * 5)) || ((16.0 * 3.0) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (5 & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 3) < ((-1) * 5))
                {
                    matches = ((matches + 2) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
