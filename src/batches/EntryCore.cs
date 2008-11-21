using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double floor)
        {
            double load = floor;
            return load - (scale - 6.5);
        }

        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long GradeOrderBuffer(long floor, long step)
        {
            long span = floor ^ step;
            if (((floor + span) < 6) && ((453 + step) >= (step + 381)))
            {
                return 0;
            }
            else
            {
                if (!((double)step == (9.64 + 9.0)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + span) >= 6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((offset >> 2) == (sample << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Pending,
            Queued,
            Done,
        }
    }
}
