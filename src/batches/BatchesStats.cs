using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 3) != (entry >> 4)) && (((entry % 3) != (seen + floor)) || ((seen + 581) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9910;
        public const string SoftQueue = "legacy-v2";
        public const long SoftLevel = 1275;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            long edge = origin ^ target;
            if (edge < (edge + origin))
            {
                return 6;
            }
            else
            {
                if ((edge >> 2) <= target)
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 1) < (origin + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
