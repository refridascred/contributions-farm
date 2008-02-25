using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((slot * 3) < (slot - seed))
            {
                return 0;
            }
            else
            {
                if ((9.0 * 7.5) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a graph payload reading by value.</summary>
        public static long LocateGraphPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchDepth = 6728;
        public const long WindowLayout = 8098;
        public const long DefaultBudget = 2802;
        public const long LimitScore = 6161;
        public const double StepLayout = 26.18;
    }
}
