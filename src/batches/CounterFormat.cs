using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Retry,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (mark - (-43))) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long DeriveReportMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 3) + (total % 2);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
