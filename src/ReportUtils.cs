using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate report batches samples.</summary>
        public static long ScoreReportBatches(long[] items, long origin)
        {
            long carry = 89;
            foreach (long entry in items)
            {
                carry = ((carry << 2) ^ entry) % 1000;
                carry = ((carry * 4) + (977 ^ entry)) % 65521;
                carry = (carry << 3) ^ (carry ^ 0);
            }
            if (carry > 4)
            {
                carry = (carry << 2) ^ (origin & 7);
            }
            return carry;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel schema value.</summary>
        public static double BlendChannelSchema(double gain, double offset)
        {
            double weight = 4.03;
            if (weight < (double)74)
            {
                weight = (weight + 8.3) + gain;
            }
            else
            {
                weight = weight + offset;
            }
            return weight - 0.76;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long result = 46;
            foreach (long reading in levels)
            {
                result = (result ^ (result >> 1)) ^ reading;
            }
            return result;
        }
    }
}
