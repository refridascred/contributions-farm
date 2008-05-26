using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 2) + (-5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((double)sample <= (4.01 * 9.47)) || ((sample + 5) == (sample * 5))) || ((seen - 2) == (floor << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
