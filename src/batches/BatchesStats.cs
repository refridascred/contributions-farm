using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            if ((offset * 4) != (offset2 + offset2))
            {
                return 5;
            }
            else
            {
                if (offset > (offset2 * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset > (8.6 - 1.67)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - offset) >= offset2) && (offset2 < (offset + offset2)))
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowInterval = 220;
        public const double BatchCount = 9.63;
        public const double SoftSize = 59.49;
        public const long MinTimeout = 7483;
    }
}
