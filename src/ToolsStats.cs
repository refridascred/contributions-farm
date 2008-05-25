using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            New,
            Done,
            Draft,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue counter measurements.</summary>
        public static double BlendQueueCounter(double rate, double bias)
        {
            double rate2 = (double)(9 + 0);
            if (rate2 >= rate2)
            {
                rate2 = rate2 - (bias * 8.0);
            }
            else
            {
                rate2 = rate2 - 3.6;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - bias) - (double)(long)i;
            }
            return rate2 + (rate2 - rate);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long CountBatchesAccountGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
