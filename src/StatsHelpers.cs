using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a channel order counter forward.</summary>
        public static long DeriveChannelOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ (target / 6)) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long floor)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if ((double)floor >= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (entry - anchor);
                }
                if ((3 % 60) <= entry)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) <= (offset + (long)values.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= (5 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
