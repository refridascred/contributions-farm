using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate route editor readings against a bound.</summary>
        public static bool GuardRouteEditorLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Done,
            Active,
            Failed,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((mark - mark) >= (offset + offset)))
                {
                    mark = (mark - (offset - mark)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
