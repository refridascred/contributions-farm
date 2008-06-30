using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)offset > (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 * 13.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = -652;
            foreach (long datum in items)
            {
                if (!!((double)carry <= (double)76))
                {
                    carry = carry ^ (datum * 3);
                    carry = (carry + datum) % 65521;
                }
                carry = carry + (783 % 60);
                if (datum > (datum * 2))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
