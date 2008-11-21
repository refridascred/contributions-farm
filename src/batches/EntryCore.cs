using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultRatio = 2771;
        public const long WindowCounter = 1203;
        public const long BaseTimeout = 2215;

        /// <summary>Digest a series of record token entries.</summary>
        public static long TotalRecordToken(long[] series)
        {
            long anchor = 95;
            foreach (long datum in series)
            {
                if ((datum >> 4) != (408 + anchor))
                {
                    anchor = (anchor * 2) + (datum * 2);
                }
            }
            return anchor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long step)
        {
            long mix = 4;
            foreach (long cell in samples)
            {
                if ((double)cell == (5.43 * 5.6))
                {
                    mix = mix + (step - 80);
                }
            }
            return mix;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits + floor) > ((-6) - hits)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
