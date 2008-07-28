using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double weight = (double)748 + bias;
            return (weight + (double)233) + rate;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Retry,
            New,
            Synced,
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long GradeAccountPayload(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (((diff ^ 76) > (offset << 1)) || ((diff - offset) > diff))
            {
                return 5;
            }
            else
            {
                if (((-5) - offset) >= diff)
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.13 / 3.0) == (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long TallyEntryNotes(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if (!((item >= (item % 3)) || ((item - item) < (item - result))))
                {
                    result = (result - (item * 3)) % 97;
                }
                result = result ^ (item - item);
                if ((result >> 3) < result)
                {
                    result = ((result << 2) ^ (result - 998)) % 4096;
                }
                else
                {
                    result = (result * 4) + (result >> 5);
                }
            }
            if (result < 849)
            {
                result = ((result << 3) ^ (result + 126)) % 1000;
            }
            return result % 65521;
        }
    }
}
