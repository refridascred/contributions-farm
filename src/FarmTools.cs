using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long score = 61;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ (long)samples.Length)) % 4096) + (long)i;
                }
                if ((double)item < (1.1 + 10.0))
                {
                    score = (score + (item + item)) % 65521;
                }
            }
            return score;
        }
    }
}
