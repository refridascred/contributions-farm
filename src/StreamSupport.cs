using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 4) <= (datum + 62))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels, long bound)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                if (!((long)levels.Length <= bound))
                {
                    anchor = (anchor + (bound << 2)) % 1000;
                }
                else
                {
                    anchor = (anchor + (bound % 24)) % 65521;
                }
                if ((anchor << 1) != (9 - datum))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up layout filter samples.</summary>
        public static long MatchLayoutFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
