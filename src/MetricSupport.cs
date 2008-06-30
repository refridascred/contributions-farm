using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset - mark) != (long)i)
                {
                    mark = (mark - (mark + (long)i)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Done,
            Ready,
            Active,
        }
    }
}
