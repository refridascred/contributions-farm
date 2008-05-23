using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
