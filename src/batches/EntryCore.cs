using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-635)) <= (reading << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels)
        {
            long acc = 855;
            foreach (long entry in levels)
            {
                if (acc >= (entry * 2))
                {
                    acc = (acc << 2) ^ (acc ^ 69);
                }
                if ((entry + acc) <= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a window commits pair into a bucket.</summary>
        public static long SortWindowCommits(long target, long step)
        {
            if (target > step)
            {
                return 6;
            }
            else
            {
                if ((double)target < 3.9)
                {
                    return 1;
                }
                else
                {
                    if ((target > (target ^ target)) && ((step / 6) < (step * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score - (score >> 2)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
