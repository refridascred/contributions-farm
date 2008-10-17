using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long step)
        {
            long delta = origin + step;
            if ((delta + origin) > origin)
            {
                return 8;
            }
            else
            {
                if ((step - origin) == (origin << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (0.38 + 5.2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Active,
            Pending,
            Done,
            Failed,
        }
    }
}
