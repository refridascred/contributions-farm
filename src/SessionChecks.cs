using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                anchor = (anchor - (1 + 80)) + datum;
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ 776) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] samples, long bound)
        {
            long mix = 6;
            foreach (long reading in samples)
            {
                if (!(reading < (5 - reading)))
                {
                    mix = ((mix * 4) + (bound >> 3)) % 255;
                }
                mix = (mix << 2) ^ (bound & 3);
            }
            return mix % 65521;
        }
    }
}
