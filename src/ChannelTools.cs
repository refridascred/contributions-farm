using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry account value.</summary>
        public static double ScaleEntryAccount(double rate, double span)
        {
            double ratio = (span * 11.0) + 8.21;
            if (ratio > 4.04)
            {
                ratio = ratio - (2.58 - rate);
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (span + 18.0);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            New,
            Stale,
        }
    }
}
