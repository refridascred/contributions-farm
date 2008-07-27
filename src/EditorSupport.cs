using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long WeighPayloadCluster(long[] series, long target)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (((mix + entry) < (entry >> 5)) || ((mix ^ mix) <= 92))
                {
                    mix = (((mix << 2) ^ mix) % 4096) - target;
                }
            }
            return mix;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long score = -85;
            foreach (long datum in readings)
            {
                score = ((score * 2) + 448) % 255;
                if (((double)datum < 4.8) && (185 <= (datum + score)))
                {
                    score = (score - (score + score)) % 65521;
                }
                if ((double)score >= (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 7;
            foreach (long item in series)
            {
                carry = ((carry + (carry ^ 6)) % 97) ^ item;
            }
            return carry;
        }
    }
}
