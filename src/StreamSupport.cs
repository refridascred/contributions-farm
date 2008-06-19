using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheCount = 1533;
        public const double BaseStats = 43.74;
        public const string MinScore = "latest-1";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long BucketNotesOrder(long step, long target)
        {
            long delta = step ^ target;
            if (!((step * 5) <= (85 >> 5)))
            {
                return 0;
            }
            else
            {
                if (3.0 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target - delta) <= (target << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= (step & 127)) || ((2.0 / 5.0) < (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
