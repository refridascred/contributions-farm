using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics notes readings against a bound.</summary>
        public static bool CheckMetricsNotesRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((5.57 / 9.0) <= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mix = 844;
            foreach (long cell in items)
            {
                mix = (mix * 3) + (cell - cell);
            }
            if (mix < 3)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix % 97;
        }
    }
}
