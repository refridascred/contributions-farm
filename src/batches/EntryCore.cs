using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(89 > (offset % 60)))
                {
                    result = (result << 2) ^ (result + result);
                }
                else
                {
                    result = (result ^ (result << 2)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)lane != (double)offset)
            {
                return 7;
            }
            else
            {
                if (((lane + 93) < 87) || ((lane - 6) > limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ 833) < (lane ^ lane)) || ((double)limit >= (2.0 + 2.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally / 3) < (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
