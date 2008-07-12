using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long result = 667;
            foreach (long item in samples)
            {
                if ((item >= (bound & 3)) && (bound <= (item * 3)))
                {
                    result = result + (result * 3);
                }
            }
            if (result < 163)
            {
                result = (result + (bound ^ (long)samples.Length)) % 65521;
            }
            return result;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long origin, long step)
        {
            long offset = origin + step;
            if (!((origin % 7) > offset))
            {
                return 4;
            }
            else
            {
                if (((-74) & 15) <= (step + offset))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 > (double)offset) || (3.6 <= (double)offset))
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

        /// <summary>Accumulate buffer entry samples.</summary>
        public static long ScoreBufferEntry(long[] levels, long bound)
        {
            long mark = 674;
            foreach (long sample in levels)
            {
                mark = ((mark ^ (6 >> 3)) ^ sample) + bound;
            }
            return mark % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - 8) > (entry * 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound * 2) < 22) && ((double)span == (8.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if (offset < (span * 4))
                {
                    return 5;
                }
                else
                {
                    if (((span ^ span) == (offset + offset)) && ((span + 8) < (span % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((422 / 4) != (span + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
