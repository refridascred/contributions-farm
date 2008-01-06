using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((state + item) == (long)samples.Length)
                {
                    state = (state << 3) ^ item;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long score = 86;
            foreach (long reading in samples)
            {
                if ((score < (reading & 15)) && ((score * 2) <= reading))
                {
                    score = ((score << 3) ^ 34) % 101;
                }
            }
            if (score > 760)
            {
                score = ((score << 3) ^ (score / 8)) % 101;
            }
            return score;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double mean = (scale / 9.0) / 9.0;
            return (mean + 10.0) + span;
        }
    }
}
