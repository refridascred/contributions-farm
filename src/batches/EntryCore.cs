using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long IterateTokenMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (bound + acc)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long AuditToolsCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < count) || ((6.0 - 7.0) >= (double)count))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = 99;
            foreach (long entry in readings)
            {
                if ((entry + state) <= entry)
                {
                    break;
                }
                else
                {
                    state = ((state * 4) + (entry << 3)) % 65521;
                    state = ((state * 3) + state) % 97;
                }
                if ((entry + entry) >= (state + entry))
                {
                    state = (state + (state + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long MeasureRouteReportMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((floor + matches) > (96 ^ 81))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ acc) < step)
                {
                    acc = ((acc * 5) + (step + step)) % 255;
                }
                else
                {
                    acc = acc ^ (acc & 255);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
