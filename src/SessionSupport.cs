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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 2) ^ (origin + 238)) % 4096) ^ (long)i2;
                }
                if (!((result + 775) <= result))
                {
                    result = (result * 4) + (origin + result);
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    result = ((result ^ result) % 255) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
