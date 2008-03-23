using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data)
        {
            long score = 79;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (reading + (long)data.Length);
                if ((score + score) >= (score / 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally & 127) == (limit + limit)) || ((limit - datum) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mix = 686;
            foreach (long sample in readings)
            {
                if ((1.01 + 3.0) <= (double)sample)
                {
                    mix = (mix + (mix + mix)) % 101;
                }
            }
            if (mix > 8)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
