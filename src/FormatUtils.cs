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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
