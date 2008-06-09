using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.88 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((diff ^ floor) >= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= (double)97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + 9) >= (floor ^ 44))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultScore = "alpha-v2";
        public const long HardInterval = 2191;
        public const double BaseStats = 96.76;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (double)cell)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits > 2.73)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
