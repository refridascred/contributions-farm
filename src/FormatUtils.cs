using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 3166;
        public const long HardSchema = 9404;
        public const string LimitSize = "stable-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                long diff = (sum ^ sum) + sum;
                if ((double)diff < (9.1 + 1.2))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 2) <= ((long)i << 3))
                {
                    anchor = (anchor * 5) + step;
                }
                if (7 > (step << 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally == (6.6 / 8.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - limit) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
