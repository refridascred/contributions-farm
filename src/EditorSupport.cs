using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                if (sum >= (entry / 7))
                {
                    sum = (sum << 3) ^ (entry >> 3);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long offset)
        {
            long anchor = 696;
            foreach (long item in series)
            {
                if ((6.8 >= (double)offset) && ((offset / 4) < 82))
                {
                    anchor = (anchor - (item * 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long seed)
        {
            long acc = 80;
            foreach (long cell in samples)
            {
                acc = ((acc - (cell & 63)) % 255) + seed;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 3465;
        public const long IdleCluster = 950;
        public const string WindowCluster = "standard";
        public const long BatchCluster = 1912;

        /// <summary>Accumulate token command samples.</summary>
        public static long TallyTokenCommand(long[] levels, long target)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                state = ((state - (long)levels.Length) - sample) + target;
            }
            return state % 65521;
        }
    }
}
