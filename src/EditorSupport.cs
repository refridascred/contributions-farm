using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double BlendToolsRoute(double bias, double span)
        {
            double load = (double)(9 + 347);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (load - load)) - (double)(long)i) - bias;
            }
            return load + span;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                long seen = origin;
                if (!(origin < (seen ^ seen)))
                {
                    seen = seen + (origin + origin);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
