using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)origin <= 2.78) || ((double)999 != (double)hits))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 3) ^ (98 + 610)) % 65521;
                if (!((mark <= ((long)i + offset)) && ((offset >> 4) <= (mark + (long)i))))
                {
                    mark = (mark ^ 72) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheBudget = "alpha-edge";
        public const string BurstScore = "legacy";
        public const long BaseSupport = 4901;
        public const long BurstInterval = 2758;
        public const long CacheSupport = 4966;

        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long OverlapEditorCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix >= (double)bound)
                {
                    mix = mix + (mix / 5);
                }
                else
                {
                    mix = mix ^ 222;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
