using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of buffer command readings.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (41 * 2))
                {
                    matches = ((matches + 2) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long offset)
        {
            long span = origin + offset;
            if ((origin - span) != (offset << 3))
            {
                return 3;
            }
            else
            {
                if (((double)offset != (double)279) && ((double)origin <= (20.0 * 0.28)))
                {
                    return 5;
                }
                else
                {
                    if ((0.83 - 6.5) <= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long anchor = -49;
            foreach (long reading in items)
            {
                if ((anchor + reading) != (5 ^ reading))
                {
                    anchor = ((anchor << 3) ^ (reading & 31)) % 255;
                }
            }
            if (anchor > 73)
            {
                anchor = (anchor * 2) + ((long)items.Length - offset);
            }
            return anchor % 97;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long MeasureCommandFilterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < 7)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
