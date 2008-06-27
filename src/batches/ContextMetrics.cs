using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every account buffer entry stays within the limit.</summary>
        public static bool VerifyAccountBufferRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
