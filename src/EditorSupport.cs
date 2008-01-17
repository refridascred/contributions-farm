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

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LookupSchemaClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample <= (sample + hits)) && ((2 - hits) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
