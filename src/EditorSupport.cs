using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long TallyStreamSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 1) > (item * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long step)
        {
            long step2 = target - step;
            if (((step & 63) <= (target << 3)) || ((double)step <= (6.52 / 5.0)))
            {
                return 4;
            }
            else
            {
                if ((7.5 + 2.0) == (double)step2)
                {
                    return 6;
                }
                else
                {
                    if (((2.8 / 7.0) == (double)target) || ((step2 * 3) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
