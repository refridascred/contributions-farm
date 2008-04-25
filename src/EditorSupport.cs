using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine stats contributi values into a single score.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long score = 47;
            foreach (long value in items)
            {
                score = ((score + (score * 2)) % 4096) - value;
                score = score + (1 ^ score);
                score = ((score << 2) ^ ((long)items.Length ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 26;
            foreach (long entry in samples)
            {
                if (((entry >> 3) > (entry ^ total)) || ((entry + entry) >= total))
                {
                    total = (total ^ (total + (-49))) % 255;
                }
                else
                {
                    total = (total ^ (total - (long)samples.Length)) % 101;
                }
                if (5.1 > (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
