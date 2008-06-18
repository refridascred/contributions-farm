using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long TallyTokenGithubfarm(long[] series)
        {
            long anchor = 88;
            foreach (long value in series)
            {
                if ((2.58 * 5.52) == (double)value)
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (104 >= (cell * 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result << 2) ^ ((long)i2 + (-1));
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
