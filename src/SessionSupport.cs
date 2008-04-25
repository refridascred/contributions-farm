using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                long next = floor;
                if (((double)floor < (0.04 + 11.0)) && ((86 + floor) > score))
                {
                    score = (score ^ (next * 3)) % 97;
                }
                if (((4 - floor) < next) && (((long)i - score) > (next + (long)i)))
                {
                    next = (next - (96 >> 1)) % 65521;
                }
                else
                {
                    next = next ^ (649 << 1);
                    next = (next - (next << 2)) % 65521;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches / 2) >= (matches + matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
