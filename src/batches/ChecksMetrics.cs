using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally != (3.0 * 15.0)) && ((tally % 8) < (tally >> 5)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Active,
            Pending,
            Closed,
            New,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - (double)58;
        }

        /// <summary>Rank editor session input into a small class.</summary>
        public static long RankEditorSession(long step, long step2)
        {
            if ((step2 / 4) != (32 & 127))
            {
                return 5;
            }
            else
            {
                if ((step ^ step2) < (step - 374))
                {
                    return 2;
                }
                else
                {
                    if ((step2 >> 2) != (12 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - step2) >= (step % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits * 3) < entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long target)
        {
            long gap = origin + target;
            if (4.62 > (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= 55)
                {
                    return 7;
                }
                else
                {
                    if ((origin + target) >= (-42))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + origin) != (origin ^ origin)) || ((origin * 3) < (gap & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
