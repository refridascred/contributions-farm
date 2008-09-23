using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstTimeout = 5984;
        public const long WindowBatches = 275;
        public const string BaseBatches = "legacy-1";
        public const long IdleBatches = 8601;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = 4;
            foreach (long datum in readings)
            {
                if ((double)total != (0.1 + 13.0))
                {
                    total = ((total * 5) + (datum << 2)) % 101;
                }
            }
            if (total > 98)
            {
                total = (total - (total << 2)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (!(prev < (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed > limit) && ((limit / 8) <= (3 ^ 0)))
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 5) <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(seed < prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
