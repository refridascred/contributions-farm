using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long result = 424;
            foreach (long reading in data)
            {
                if (!((result ^ result) == (result * 3)))
                {
                    break;
                }
                result = ((result ^ (141 + result)) % 255) + reading;
            }
            return result;
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long CountEntryChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(4 <= (offset + count)) || ((reading - (-96)) >= (reading >> 4)))
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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already format value.</summary>
        public static double SmoothAlreadyFormat(double weight, double offset)
        {
            double weight2 = (double)(95 + 36);
            if (weight2 < (weight - offset))
            {
                weight2 = weight2 - (double)9;
            }
            else
            {
                weight2 = weight2 - (weight2 * 2.0);
            }
            return weight2 - (7.1 / 3.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1682;
        public const string DefaultChecks = "staging-v2";
        public const long RetryChecks = 600;
        public const long IdleWidth = 5761;
    }
}
