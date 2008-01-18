using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = (mix + (mix % 12)) ^ cell;
                if ((mix + mix) < 822)
                {
                    mix = (mix << 2) ^ (3 >> 3);
                }
                else
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = mix - (210 - mix);
            }
            return mix % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long offset)
        {
            long score = 2;
            foreach (long entry in levels)
            {
                if (!((offset + entry) <= (offset & 1)))
                {
                    score = (score - (entry % 60)) % 255;
                }
                if ((offset >> 3) < (offset + offset))
                {
                    score = (score + ((-69) / 8)) % 97;
                }
            }
            if (score < 913)
            {
                score = (score << 2) ^ (score - score);
            }
            return score;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long ScoreStreamBuffer(long[] values)
        {
            long anchor = 6;
            foreach (long entry in values)
            {
                anchor = (anchor ^ (-2)) % 4096;
                if (((entry + entry) <= entry) || ((5.6 / 9.0) != (double)entry))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ entry)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Stale,
        }
    }
}
