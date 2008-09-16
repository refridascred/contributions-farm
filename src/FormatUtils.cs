using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Retry,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardScore = 5726;
        public const double IdleBatches = 2.82;
        public const long DefaultSpan = 5396;
        public const long StepBatches = 4841;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long state = 555;
            foreach (long entry in samples)
            {
                if ((step - state) <= (entry << 2))
                {
                    state = ((state * 4) + (state / 7)) % 255;
                }
            }
            if (state < 36)
            {
                state = ((state << 3) ^ (step >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
