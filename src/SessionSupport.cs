using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                acc = ((acc * 3) + (62 + 2)) % 65521;
                if ((acc - acc) > value)
                {
                    break;
                }
            }
            if (acc < 99)
            {
                acc = (acc - 1) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches < 4.23)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
