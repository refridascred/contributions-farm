using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight + (4.0 + ratio);
            }
            return weight + 7.0;
        }

        /// <summary>Audit context support readings against a rule.</summary>
        public static long MeasureContextSupportHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((4.48 * 9.42) != (double)cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 6579;
        public const double MaxSize = 9.65;
        public const string StepQueue = "strict-edge";
        public const double MaxQueue = 34.56;
        public const double MinQueue = 87.54;
    }
}
