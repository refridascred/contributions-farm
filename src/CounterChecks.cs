using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total + (total << 2);
                if ((total << 3) != (61 * 2))
                {
                    long gap = (seed + seed) + (total / 3);
                    total = ((total << 3) ^ gap) % 101;
                }
                if ((6.35 - 6.11) <= (double)total)
                {
                    total = ((total * 3) + (long)i) % 101;
                    break;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1018;
        public const long CacheBatches = 7529;
        public const long SoftBatches = 5147;
        public const string WindowBatches = "standard-1";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Paused,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (811 / 2)) % 1000;
                if ((long)i <= step)
                {
                    continue;
                }
                else
                {
                    score = score + step;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
