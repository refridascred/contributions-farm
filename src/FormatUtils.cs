using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session checks value.</summary>
        public static double BlendSessionChecks(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > 5.2)
            {
                ratio = (ratio - (1.0 * 4.0)) + gain;
            }
            return ratio + (double)15;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                score = (score << 3) ^ value;
                if (((score & 3) != (value - value)) && ((score ^ score) < (score << 1)))
                {
                    break;
                }
            }
            if (score > 719)
            {
                score = (score + ((long)items.Length + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] values, long target)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = ((mix + (datum + datum)) % 255) - target;
            }
            return mix % 97;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (reading - matches))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
