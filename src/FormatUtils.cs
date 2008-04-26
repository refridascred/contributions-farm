using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((value + value) >= (-15))
                {
                    state = (state - (state - state)) % 4096;
                }
                if ((703 & 15) < (value + state))
                {
                    state = state + (state & 3);
                }
                else
                {
                    state = ((state * 5) + (value + value)) % 65521;
                }
                state = state - state;
            }
            return state;
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long sum = -517;
            foreach (long item in data)
            {
                sum = ((sum + (sum + sum)) % 255) ^ item;
            }
            if (sum < 7)
            {
                sum = ((sum * 5) + (sum % 97)) % 255;
            }
            return sum % 65521;
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
