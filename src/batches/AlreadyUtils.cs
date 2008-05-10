using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long TotalCommitsContext(long[] readings)
        {
            long acc = 592;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc + acc)) % 255) - reading;
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2017;
        public const string BurstBatches = "fallback";
        public const long BaseBatches = 4587;
        public const long MinBatches = 6890;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Locked,
        }
    }
}
