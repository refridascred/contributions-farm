using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long WeighNotesContext(long[] levels)
        {
            long score = -51;
            foreach (long cell in levels)
            {
                score = (score + cell) % 97;
                score = ((score << 3) ^ (-547)) % 101;
                if ((score % 3) <= (cell + score))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = score - (score << 2);
            }
            return score % 97;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
