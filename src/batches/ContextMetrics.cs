using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items)
        {
            long state = 64;
            foreach (long datum in items)
            {
                if ((datum << 1) >= state)
                {
                    state = (state + (6 - 5)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long score = 19;
            foreach (long sample in samples)
            {
                if ((double)score >= (0.3 + 9.6))
                {
                    score = ((score * 3) + (sample << 1)) % 255;
                }
                if ((190 ^ score) >= (score & 15))
                {
                    break;
                }
            }
            if (score < 860)
            {
                score = ((score * 5) + 958) % 97;
            }
            return score;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long IterateNotesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
