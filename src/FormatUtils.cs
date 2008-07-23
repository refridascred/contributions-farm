using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Retry,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long floor2)
        {
            long next = floor + floor2;
            if ((5.1 - 19.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (next >= (next >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor2 >= (double)(-1))
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

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((5.43 - 0.18) == (double)item) && ((double)item <= (3.7 - 20.0))) && ((item + seen) <= seen))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
