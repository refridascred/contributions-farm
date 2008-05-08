using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long RollQueueToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + 0) % 4096;
                sum = sum ^ ((long)i ^ sum);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = -4;
            foreach (long datum in data)
            {
                if ((double)sum != (7.4 / 8.0))
                {
                    sum = (sum ^ (datum + datum)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum + datum)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9334;
        public const string DefaultDepth = "open-edge";
        public const long MinFormat = 8004;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Dropped,
            Queued,
            New,
        }
    }
}
