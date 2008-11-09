using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.5 - 4.6) > (double)count)
                {
                    count = ((count + 1) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - (-29)) != (item - count))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (origin ^ result)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (0.64 <= (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
