using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Ready,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Audit window filter readings against a rule.</summary>
        public static long MeasureWindowFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((entry >> 2) <= entry) && ((count - entry) < (entry + count))) && (entry > (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up command token samples.</summary>
        public static long PairCommandTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
