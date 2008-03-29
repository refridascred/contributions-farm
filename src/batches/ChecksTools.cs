using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix >> 1) >= value)
                {
                    mix = ((mix << 3) ^ (value * 5)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(hits < 19))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long origin)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (entry <= (origin << 2))
                {
                    total = (total + (85 + total)) % 4096;
                }
                if ((double)entry <= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
