using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the record entry series from a seed.</summary>
        public static long DeriveRecordEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Queued,
        }
    }
}
