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

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = (result << 2) ^ ((long)levels.Length + result);
                result = result ^ (result % 3);
                if ((double)sample < (10.0 - 12.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
