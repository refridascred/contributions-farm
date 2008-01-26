using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Ready,
            New,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data)
        {
            long mix = 551;
            foreach (long reading in data)
            {
                if ((mix - reading) >= (mix + reading))
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if (total <= (floor >> 1))
                {
                    total = total - (floor / 7);
                }
                total = ((total << 3) ^ (total - (long)i)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a editor batches reading by value.</summary>
        public static long FindEditorBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
