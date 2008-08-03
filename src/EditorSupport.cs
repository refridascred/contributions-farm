using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long CountContributiQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits ^ hits) <= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 448;
            foreach (long sample in items)
            {
                if (mark < sample)
                {
                    mark = (mark - (mark - sample)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many contributi payload samples are out of range.</summary>
        public static long TallyContributiPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (hits << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
