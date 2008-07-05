using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool VerifyPayloadAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values, long seed)
        {
            long acc = 89;
            foreach (long entry in values)
            {
                acc = acc - (acc >> 3);
                if (!((double)seed < (2.6 - 6.41)))
                {
                    acc = (acc ^ (seed / 3)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + 5) % 101;
                }
                if ((acc & 63) >= (entry ^ entry))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
