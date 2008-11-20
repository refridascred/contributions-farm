using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseScore = "fallback-1";
        public const long CacheNotes = 5247;
        public const double BurstLevel = 33.29;
        public const long StepDepth = 8877;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long offset)
        {
            if ((origin ^ 12) < (origin % 12))
            {
                return 3;
            }
            else
            {
                if (((75 % 100) < (offset - origin)) || ((origin * 2) < offset))
                {
                    return 5;
                }
                else
                {
                    if (!(origin < (origin % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + offset) > (offset / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
