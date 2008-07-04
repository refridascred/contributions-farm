using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long step)
        {
            if (((origin ^ 341) != (origin % 3)) && ((step + (-92)) <= (origin + origin)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) < origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches > (matches ^ (-85)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((bound - 7) < bound)
            {
                return 0;
            }
            else
            {
                if ((step & 15) < bound)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step) == (bound / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound ^ (-253)) > 5) && ((step ^ bound) != (bound ^ bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count route entry pairs that satisfy a relation.</summary>
        public static long PairRouteEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
