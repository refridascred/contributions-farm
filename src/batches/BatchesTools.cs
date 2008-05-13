using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Digest a series of notes stream entries.</summary>
        public static long WeighNotesStream(long[] series)
        {
            long mix = 628;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix - (sample >> 5)) % 255;
                    mix = (mix + ((long)i + sample)) % 101;
                }
                if ((sample & 255) > (25 & 15))
                {
                    mix = (mix << 3) ^ (mix ^ (-5));
                }
            }
            return mix;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
