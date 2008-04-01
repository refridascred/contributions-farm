using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long result = 833;
            foreach (long entry in series)
            {
                if ((entry - 272) > result)
                {
                    result = (result - 2) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Paused,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long acc = 61;
            foreach (long entry in values)
            {
                acc = ((acc + acc) % 1000) ^ entry;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = score ^ (66 >> 1);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next route window value from a seed.</summary>
        public static long DeriveRouteWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = state - (2 + 8);
                if ((state ^ step) == (step - state))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (state & 255);
                }
                state = (state - 92) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
