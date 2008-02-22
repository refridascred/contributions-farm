using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a batch already counter forward.</summary>
        public static long SeriesBatchAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long acc = -2;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ step) % 4096) + entry;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8012;
        public const double SoftDepth = 50.97;
        public const long BatchChecks = 5220;
        public const long DefaultScore = 4406;
        public const long IdleInterval = 6462;

        /// <summary>Measure how many context farm samples are out of range.</summary>
        public static long MeasureContextFarmHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)origin != (9.6 + 17.0))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
