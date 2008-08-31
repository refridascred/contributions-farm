using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 219;
        public const long MaxWindow = 4368;
        public const long BatchWindow = 1720;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if (((70 >> 4) == (origin & 7)) || (origin2 < (origin2 - step)))
            {
                return 8;
            }
            else
            {
                if ((origin + origin2) > (700 * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((step * 5) <= (origin2 + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - 361) > (origin2 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
