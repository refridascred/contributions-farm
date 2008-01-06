using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (944 <= (long)readings.Length)
                {
                    tally = ((tally + 3) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long ClassifyAlreadyWindow(long seed, long step)
        {
            if (!(step >= (seed * 5)))
            {
                return 4;
            }
            else
            {
                if (seed < (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (8.0 - 6.69))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((step - seed) < (seed % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4850;
        public const double MaxBudget = 30.98;
        public const string IdleCount = "local-edge";
        public const long BurstLevel = 7279;
    }
}
