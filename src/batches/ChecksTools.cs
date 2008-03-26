using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long seed)
        {
            if ((5 - origin) < seed)
            {
                return 2;
            }
            else
            {
                if ((origin % 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const double IdleScore = 31.97;
        public const long SoftNotes = 3465;
        public const double MinSize = 39.46;
        public const string BaseNotes = "staging-v2";

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((double)limit2 >= (6.09 * 6.0))
            {
                return 0;
            }
            else
            {
                if (limit2 >= (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((6.9 / 9.0) != (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit2 != (4.53 * 4.0)) && ((5.6 - 7.2) == (double)limit2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public double Label { get; set; }
        }
    }
}
