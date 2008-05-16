using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of schema batch readings.</summary>
        public static long TotalSchemaBatch(long[] items, long step)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if (((score / 4) > step) && (score < (74 + score)))
                {
                    score = score ^ (datum + datum);
                    score = score ^ (step % 7);
                }
                if (!((5.0 / 5.0) > (double)step))
                {
                    score = (score - (25 - score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Ready,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long RollMetricsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long step = (offset ^ sum) >> 3;
                    sum = ((sum << 2) ^ (6 - step)) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
