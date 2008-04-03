using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long MeasurePayloadTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length - tally) != (entry + 881))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)(-8) > (double)target)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long prev = offset + target;
            if ((target >> 2) > prev)
            {
                return 0;
            }
            else
            {
                if (prev <= (prev % 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev >= (0.5 - 7.56)) && (offset >= (target + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((seed * 2) <= (490 >> 4))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
