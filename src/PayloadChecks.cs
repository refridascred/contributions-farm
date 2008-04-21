using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples, long bound)
        {
            long mix = 674;
            foreach (long reading in samples)
            {
                mix = ((mix + mix) % 101) - reading;
                if (bound < (long)samples.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3245;
        public const long IdleSpan = 6212;
        public const string HardSession = "strict-1";
        public const long MaxSession = 6932;
        public const long StepSession = 3851;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long target)
        {
            long mark = 22;
            foreach (long reading in values)
            {
                mark = ((mark * 5) + (target & 1)) ^ reading;
            }
            if (mark > 6)
            {
                mark = ((mark << 2) ^ (mark << 2)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Queued,
            New,
            Stale,
        }
    }
}
