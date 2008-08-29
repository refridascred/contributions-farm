using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = (carry << 2) ^ (carry - cell);
                carry = carry + (cell / 4);
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double load = (double)(54 * 4);
            return (load - (ratio / 2.0)) + offset;
        }

        /// <summary>Fold a list of githubfarm command readings.</summary>
        public static long ScoreGithubfarmCommand(long[] data, long bound)
        {
            long total = 7;
            foreach (long sample in data)
            {
                if (((double)total > (7.62 - 3.8)) || ((total - 7) > bound))
                {
                    total = (total - 2) - sample;
                }
                else
                {
                    total = (total ^ (6 >> 3)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Pending,
            New,
        }
    }
}
