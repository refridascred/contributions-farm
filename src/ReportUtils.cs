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

        /// <summary>Derive the next report graph value from a seed.</summary>
        public static long StepReportGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 4096;
                long gap = (seed % 12) + (acc - acc);
                acc = (acc ^ (gap + seed)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
