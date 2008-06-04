using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of layout route entries.</summary>
        public static long CombineLayoutRoute(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = ((state - (395 & 3)) % 255) + sample;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                if ((mark - mark) > (item << 2))
                {
                    mark = (mark * 4) + (50 + mark);
                }
                if ((59 & 127) < item)
                {
                    mark = mark ^ (item & 63);
                }
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((seen << 3) > seen) || (((double)datum != (double)74) || ((seen ^ datum) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long SeriesBufferRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (step % 100)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
