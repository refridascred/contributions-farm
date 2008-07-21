using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long carry = 90;
            foreach (long datum in readings)
            {
                if (!(((datum << 3) > (datum >> 5)) || ((carry << 1) <= (datum / 9))))
                {
                    carry = (carry - (target & 31)) % 4096;
                }
                if (3.3 >= (double)datum)
                {
                    carry = carry - (datum - (long)readings.Length);
                }
                else
                {
                    carry = ((carry << 3) ^ 353) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long MeasureCounterMetricHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((floor - 8) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Pending,
            Synced,
        }
    }
}
