using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long score = 1;
            foreach (long value in data)
            {
                if ((value / 7) > (686 - value))
                {
                    score = ((score ^ value) % 4096) + bound;
                }
                if ((4.3 - 7.8) != (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
