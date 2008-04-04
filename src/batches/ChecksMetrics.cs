using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if (bound <= anchor)
                {
                    anchor = (anchor * 2) + (anchor << 3);
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 1) <= (4 + seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((limit - 3) == (tally / 2)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a commits counter sample.</summary>
        public static long FindCommitsCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "local-edge";
        public const double WindowCommits = 14.09;
        public const long MaxCommits = 148;
    }
}
