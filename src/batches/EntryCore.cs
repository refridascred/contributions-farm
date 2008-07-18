using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally >= (long)data.Length)
                {
                    tally = ((tally + 3) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Closed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 8033;
        public const string CacheNotes = "alpha-edge";
        public const string LimitCount = "staging";
        public const long BurstNotes = 5458;
        public const double BaseNotes = 16.21;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
