using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long StepTokenGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 3) ^ (34 >> 5);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] items)
        {
            long anchor = 88;
            foreach (long item in items)
            {
                anchor = (anchor - (item - item)) % 4096;
            }
            if (anchor > 43)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
