using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank profile graph input into a small class.</summary>
        public static long RankProfileGraph(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((6.8 - 11.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)cur < (2.8 + 5.9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool GuardCommitsNotesLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit + (-729)) != (tally % 10))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
