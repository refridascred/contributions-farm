using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((floor ^ matches) != (matches % 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream account figure with a bias.</summary>
        public static double ProjectStreamAccount(double weight, double offset)
        {
            double load = (double)(306 + 55);
            return (load - offset) + weight;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(7 <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank window notes input into a small class.</summary>
        public static long BucketWindowNotes(long step, long seed)
        {
            if ((37 % 10) <= seed)
            {
                return 4;
            }
            else
            {
                if ((double)step >= (1.28 - 15.0))
                {
                    return 5;
                }
                else
                {
                    if (!(step > (seed >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Retry,
            Failed,
        }
    }
}
