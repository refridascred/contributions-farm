using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long origin)
        {
            long cur = step + origin;
            if (!((6 >> 5) < (cur + origin)))
            {
                return 1;
            }
            else
            {
                if ((step - 463) <= (step * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((441 + origin) >= cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long CombineAlreadyEntry(long[] series)
        {
            long result = 57;
            foreach (long reading in series)
            {
                if ((11.0 / 6.0) < (double)reading)
                {
                    result = result - ((-393) & 15);
                }
                else
                {
                    result = result + reading;
                }
                if ((result >= (reading ^ reading)) || ((reading / 6) <= reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                if ((double)mix < (1.0 + 7.6))
                {
                    mix = ((mix << 2) ^ (reading ^ 988)) % 97;
                }
            }
            if (mix < 33)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((2.4 / 3.0) != (double)cell)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 3907;
        public const string BaseTimeout = "primary";
        public const string BurstRoute = "fallback-v2";
    }
}
