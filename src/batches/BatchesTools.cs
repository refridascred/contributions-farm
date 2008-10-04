using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long TallyBufferTools(long[] samples, long origin)
        {
            long anchor = 358;
            foreach (long entry in samples)
            {
                anchor = ((anchor * 3) + (anchor + 0)) + entry;
                anchor = ((anchor << 3) ^ (70 << 2)) % 101;
                if ((origin & 1) > anchor)
                {
                    anchor = (anchor + origin) % 4096;
                }
                if ((double)origin == (3.0 - 9.0))
                {
                    break;
                }
            }
            if (anchor > 450)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long limit)
        {
            long mix = 340;
            foreach (long sample in data)
            {
                if ((sample - 715) < 456)
                {
                    mix = (mix + (sample >> 4)) - limit;
                }
            }
            if (mix > (-4))
            {
                mix = mix ^ (mix >> 4);
            }
            return mix % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitTimeout = 98.72;
        public const long DefaultSchema = 5155;
        public const long StepSpan = 3852;
        public const long BatchWidth = 6494;
        public const double BaseFactor = 20.77;
    }
}
