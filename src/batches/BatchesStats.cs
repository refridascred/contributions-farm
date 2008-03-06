using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowScore = 2083;
        public const long BatchToken = 2875;
        public const long SoftToken = 4570;
        public const string IdleToken = "standard-edge";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every githubfarm token entry stays within the limit.</summary>
        public static bool ValidateGithubfarmTokenRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema counter pair into a bucket.</summary>
        public static long GradeSchemaCounter(long bound, long seed)
        {
            long prev = bound - seed;
            if ((bound ^ 78) < (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((bound ^ seed) == (bound & 3))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) != (bound + prev))
                    {
                        return 5;
                    }
                    else
                    {
                        if (9.46 >= (double)prev)
                        {
                            return 7;
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
