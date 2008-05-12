using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batch order readings against a rule.</summary>
        public static long CountBatchOrderOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (limit < (hits & 255))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + 68) > (cell - cell))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mix = 7;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (mix - mix)) % 4096) ^ cell;
            }
            if (mix < 640)
            {
                mix = mix + (5 + mix);
            }
            return mix % 1000;
        }
    }
}
