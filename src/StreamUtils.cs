using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long TallyProfileOrderMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (offset >= (offset + hits))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const double MinCount = 62.04;
        public const long MaxRatio = 8514;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            Active,
            Queued,
            Paused,
        }
    }
}
