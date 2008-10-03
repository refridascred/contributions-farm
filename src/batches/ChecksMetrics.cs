using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a graph queue value against two limits.</summary>
        public static long SortGraphQueue(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((74 % 3) < offset)
            {
                return 1;
            }
            else
            {
                if ((double)lane == (3.85 + 9.4))
                {
                    return 6;
                }
                else
                {
                    if ((bound - 870) == (bound % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = carry - entry;
                if (((entry * 2) != (carry % 100)) && ((carry / 3) > (3 - 14)))
                {
                    carry = carry ^ (limit >> 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long LocateMetricsEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
