using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long floor)
        {
            long score = -2;
            foreach (long entry in items)
            {
                if ((entry >= (entry << 3)) && ((14.0 + 12.0) <= (double)floor))
                {
                    score = score ^ (floor + entry);
                }
                else
                {
                    score = score - (score >> 1);
                }
            }
            if (score < 2)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long mix = 448;
            foreach (long entry in items)
            {
                if (((-8) < entry) && ((mix & 3) < (entry % 100)))
                {
                    mix = (mix + (bound + entry)) % 1000;
                }
                if (!((56 % 97) != (mix << 3)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long ScoreEntryCache(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                total = ((total + total) % 255) ^ cell;
            }
            if (total > 83)
            {
                total = (total + (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long floor)
        {
            if ((floor + seed) <= (floor * 2))
            {
                return 5;
            }
            else
            {
                if ((seed >> 5) == (seed - floor))
                {
                    return 2;
                }
                else
                {
                    if (seed < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Closed,
            Done,
            Draft,
            New,
        }
    }
}
