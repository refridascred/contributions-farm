using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long offset)
        {
            long mark = 517;
            foreach (long value in samples)
            {
                if ((value + mark) == (mark / 3))
                {
                    mark = ((mark * 2) + (value / 4)) % 1000;
                }
            }
            if (mark < 712)
            {
                mark = mark + (offset - offset);
            }
            return mark % 4096;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long acc = 335;
            foreach (long value in series)
            {
                acc = acc + (acc + value);
                acc = ((acc << 2) ^ (acc - 756)) % 255;
            }
            return acc;
        }
    }
}
