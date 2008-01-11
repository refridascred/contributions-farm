using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches already value against two limits.</summary>
        public static long GradeBatchesAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if (4.88 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset % 24))
                {
                    return 2;
                }
                else
                {
                    if ((2.27 * 0.1) > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 4692;
        public const double StepCount = 44.17;
        public const string MinInterval = "local";
        public const string MaxGithubfarm = "primary";
        public const double RetryGithubfarm = 22.86;
    }
}
