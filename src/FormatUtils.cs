using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Done,
            Queued,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 2) <= ((long)i << 3))
                {
                    anchor = (anchor * 5) + step;
                }
                if (7 > (step << 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix > (10.0 + 4.3)) || ((bound >> 2) >= ((long)i >> 2)))
                {
                    mix = (mix * 5) + ((-892) * 3);
                    mix = mix ^ (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 1000) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((double)63 == (double)seen) && (target <= (29 ^ seen))) && (sample <= (seen + sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
