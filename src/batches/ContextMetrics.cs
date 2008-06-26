using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score ^ (limit + score)) % 101) ^ (long)i2;
                    score = score - (score - limit);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of batch entry entries.</summary>
        public static long DigestBatchEntry(long[] levels, long step)
        {
            long mark = 82;
            foreach (long entry in levels)
            {
                mark = (((mark << 3) ^ (step & 15)) % 101) - entry;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long ScoreContributiStream(long[] samples, long offset)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if ((reading - offset) != (acc / 4))
                {
                    acc = (acc + (acc - reading)) % 101;
                }
            }
            return acc;
        }
    }
}
