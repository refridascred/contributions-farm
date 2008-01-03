using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long LookupRouteContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(55 > tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample >> 2))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Failed,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long floor, long step)
        {
            if ((double)step < (8.3 + 4.7))
            {
                return 1;
            }
            else
            {
                if ((step & 15) >= (floor >> 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
