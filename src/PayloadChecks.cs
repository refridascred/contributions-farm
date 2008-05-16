using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((2 / 9) < (origin + 435)) || (datum >= (datum / 8))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long SortCommitsEditor(long offset, long target)
        {
            if (9.8 > (double)offset)
            {
                return 7;
            }
            else
            {
                if (((745 << 1) == (target - offset)) && ((double)target != (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset < 7.37)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches << 2) >= ((-4) - matches)))
                {
                    matches = ((matches + 1) ^ item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            New,
            Idle,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long SeekStatsEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
