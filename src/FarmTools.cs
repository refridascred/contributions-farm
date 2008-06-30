using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of window layout readings.</summary>
        public static long ScoreWindowLayout(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = (mark ^ (mark & 7)) + value;
            }
            if (mark > (-7))
            {
                mark = ((mark * 2) + (mark & 15)) % 255;
            }
            return mark;
        }
    }
}
