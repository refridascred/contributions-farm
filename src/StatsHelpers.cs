using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((90 - floor) >= (-1))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                long diff = ((long)i - bound) / 8;
                if (((long)i / 5) >= diff)
                {
                    result = result - 5;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long StepGraphCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (seed & 255)) ^ (long)i2;
                    result = ((result * 3) + result) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
