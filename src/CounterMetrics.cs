using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i < (4.0 * 7.0))
                {
                    result = (result - (result >> 1)) % 97;
                }
                result = result - (result << 1);
                if (8.9 > (double)step)
                {
                    result = result - 6;
                    result = (result ^ (result % 64)) % 255;
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long state = -2;
            foreach (long reading in items)
            {
                if (!((double)state >= (17.0 - 4.0)))
                {
                    state = (state ^ (77 + state)) % 4096;
                    state = state ^ (state / 6);
                }
                state = ((state << 3) ^ reading) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long AuditTokenBufferHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= (68 + 5))
                {
                    seen = ((seen + 1) + value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Match up payload token samples.</summary>
        public static long MatchPayloadTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
