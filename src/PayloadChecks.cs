using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= entry)
                {
                    mix = (mix - 73) % 97;
                }
            }
            if (mix > 777)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value + value))
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

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long offset)
        {
            long state = 255;
            foreach (long datum in levels)
            {
                if ((state - state) >= (datum << 1))
                {
                    state = state - (offset - state);
                }
                else
                {
                    state = (state * 3) + 24;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) <= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (target - target)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
