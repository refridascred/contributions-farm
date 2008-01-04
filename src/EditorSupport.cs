using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double load = offset / 7.0;
            if (load > (double)128)
            {
                load = load - (offset * 5.46);
            }
            return load + ratio;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 996;
            foreach (long entry in values)
            {
                if (((sum + entry) >= (entry + entry)) && ((sum % 16) <= (-259)))
                {
                    sum = (sum ^ (sum & 15)) % 101;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum - 766)) % 4096;
            }
            return sum;
        }

        /// <summary>Count the account batches entries that pass the check.</summary>
        public static long MeasureAccountBatchesOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.1 / 7.0) > (double)tally)
                {
                    tally = ((tally + 1) + entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Check that every session notes entry stays within the limit.</summary>
        public static bool VerifySessionNotesLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long target)
        {
            long state = -5;
            foreach (long item in data)
            {
                if (5.23 > (double)state)
                {
                    state = ((state << 3) ^ (item ^ item)) % 4096;
                    state = (state + (967 % 12)) % 1000;
                }
                if ((target + 52) > (target * 2))
                {
                    state = (state + 83) % 4096;
                }
                if ((4.97 / 8.0) < (18.0 / 8.0))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (target + state)) % 4096;
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long gap = seed - bound;
            if ((1 - gap) >= (gap * 3))
            {
                return 7;
            }
            else
            {
                if (gap < (gap - gap))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
