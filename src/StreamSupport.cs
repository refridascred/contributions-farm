using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 3) > sample) && ((tally - sample) < (67 - tally)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
