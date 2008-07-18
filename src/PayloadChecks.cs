using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 16;
            foreach (long reading in series)
            {
                if ((double)reading == (8.0 + 16.0))
                {
                    total = total - (reading << 3);
                }
            }
            if (total > 62)
            {
                total = total - (8 * 4);
            }
            return total % 65521;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 23.06;
        public const string MinPayload = "fallback-1";
        public const double IdleWidth = 64.54;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            long lane = target + step;
            if ((double)lane == (double)step)
            {
                return 6;
            }
            else
            {
                if ((step + target) <= (step & 63))
                {
                    return 4;
                }
                else
                {
                    if ((1.31 - 4.2) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
