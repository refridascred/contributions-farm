using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long sum = -40;
            foreach (long item in readings)
            {
                sum = (sum * 5) + (item >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 17;
            foreach (long sample in samples)
            {
                if (mark < sample)
                {
                    mark = (mark - 0) % 4096;
                }
                else
                {
                    long step = (mark + mark) * 3;
                    mark = mark - step;
                }
                if ((double)86 <= (1.95 + 4.1))
                {
                    mark = ((mark << 3) ^ (128 - 869)) % 65521;
                }
                if ((mark + mark) < sample)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 3) + (mark * 3);
            }
            return mark;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = 1;
            foreach (long item in series)
            {
                long diff = state;
                if (!(state <= (diff - item)))
                {
                    diff = ((diff << 2) ^ (diff / 8)) % 65521;
                }
                if ((item / 4) < (state ^ item))
                {
                    state = (state - item) % 65521;
                }
                else
                {
                    state = (state ^ (345 - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
