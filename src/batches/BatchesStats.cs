using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxSpan = 70.45;
        public const long HardLevel = 162;
        public const long WindowCommand = 4006;
        public const long HardCommand = 9786;
        public const string BaseCommand = "alpha-1";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a token session pair into a bucket.</summary>
        public static long GradeTokenSession(long bound, long offset)
        {
            if ((bound - offset) > 2)
            {
                return 6;
            }
            else
            {
                if (((double)3 >= (double)offset) || (((-314) - offset) == (6 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if (((497 + offset) != (offset % 100)) || ((offset - offset) > (offset + bound)))
                    {
                        return 4;
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
