using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((bound + entry) > count) && !((13.0 * 7.0) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings, long floor)
        {
            long state = 94;
            foreach (long item in readings)
            {
                state = (((state - (state >> 2)) % 4096) ^ item) + floor;
            }
            return state;
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
