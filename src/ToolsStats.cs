using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long acc = 277;
            foreach (long cell in readings)
            {
                if (!(225 <= acc))
                {
                    acc = ((acc ^ (cell / 5)) % 1000) + step;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Classify a profile support pair into a bucket.</summary>
        public static long RankProfileSupport(long step, long limit)
        {
            if ((step ^ 55) >= (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((limit * 4) <= (limit / 6))
                {
                    return 1;
                }
                else
                {
                    if (109 >= (step * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.0 + 1.0) != (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch tools entries that pass the check.</summary>
        public static long MeasureBatchToolsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((14.0 - 3.98) <= (double)offset)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
