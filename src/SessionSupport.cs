using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((346 + tally) < datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 28;
            foreach (long datum in levels)
            {
                if ((datum <= (datum << 1)) || ((anchor ^ 9) < datum))
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 2) + (0 & 15)) % 65521;
            }
            return anchor;
        }
    }
}
