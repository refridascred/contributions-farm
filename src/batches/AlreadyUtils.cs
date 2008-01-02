using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels, long offset)
        {
            long anchor = -80;
            foreach (long value in levels)
            {
                anchor = anchor ^ (value >> 2);
                anchor = (anchor + (offset % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 1;
            foreach (long item in levels)
            {
                total = total + (item / 2);
                if (item > (8 * 2))
                {
                    total = (total - (total * 2)) % 1000;
                }
                else
                {
                    total = total + (item << 1);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
