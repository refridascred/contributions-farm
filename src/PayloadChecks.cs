using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count >= 93) || ((reading ^ count) == (reading + reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state - (state % 60);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long mark = 881;
            foreach (long sample in values)
            {
                mark = (mark ^ (sample * 5)) - seed;
            }
            return mark % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long step)
        {
            if ((238 >> 4) <= (71 - step))
            {
                return 5;
            }
            else
            {
                if ((target / 3) <= (step - step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
