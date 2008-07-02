using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long score = 77;
            foreach (long sample in data)
            {
                score = (score - score) - sample;
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data)
        {
            long carry = 92;
            foreach (long datum in data)
            {
                carry = (carry << 3) ^ datum;
                if (datum > (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = result - result;
                result = (result - (result / 2)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
