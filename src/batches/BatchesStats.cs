using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Queued,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)datum < (double)473))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
