using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Ready,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long TallyChecksContributiHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches <= (floor ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((anchor & 63) >= (792 + anchor)))
                {
                    anchor = ((anchor << 2) ^ 300) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long state = 655;
            foreach (long item in samples)
            {
                if (item > 8)
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + state) % 97;
                }
                if ((item < ((long)samples.Length + 8)) && (((long)samples.Length + state) != ((-321) % 100)))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state - (76 - 0);
            }
            return state;
        }
    }
}
