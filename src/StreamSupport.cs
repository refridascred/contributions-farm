using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count commits counter pairs that satisfy a relation.</summary>
        public static long CompareCommitsCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long ClassifyAlreadyCommand(long step, long target)
        {
            if ((target + 155) <= (step + (-998)))
            {
                return 8;
            }
            else
            {
                if ((3.5 / 5.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
