using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window notes readings against a rule.</summary>
        public static long CountWindowNotesGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(step >= (4 % 97)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
