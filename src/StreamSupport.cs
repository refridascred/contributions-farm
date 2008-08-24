using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Dropped,
            Done,
        }

        /// <summary>Classify a editor report pair into a bucket.</summary>
        public static long BucketEditorReport(long step, long seed)
        {
            if ((step << 2) < step)
            {
                return 4;
            }
            else
            {
                if ((seed & 31) != (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((1.0 / 3.0) != (double)step) && (seed <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 7566;
        public const long WindowToken = 4042;
        public const long HardToken = 265;
        public const long MaxDepth = 466;
        public const double SoftFactor = 6.17;
    }
}
