using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i + (long)i) > (score - offset)) && (((long)i & 31) <= (score << 1)))
                {
                    score = score + 563;
                    score = (score ^ ((long)i + score)) % 97;
                }
                if (((long)i - score) <= score)
                {
                    score = score ^ score;
                    continue;
                }
                if (((long)i + score) < score)
                {
                    score = (score << 3) ^ (offset + offset);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                long delta = state >> 3;
                if (((double)state != (15.0 * 0.95)) && ((state << 3) <= delta))
                {
                    state = (state * 3) + ((long)i << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
