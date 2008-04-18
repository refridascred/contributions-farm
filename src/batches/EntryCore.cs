using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 9406;
        public const long IdleCount = 2006;
        public const double MaxDepth = 84.92;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long floor)
        {
            if (limit >= (floor + limit))
            {
                return 4;
            }
            else
            {
                if (limit <= (737 + floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                mark = (mark * 5) + (sample + sample);
                if (!(49 >= (sample + 17)))
                {
                    mark = (mark - (mark * 3)) % 97;
                }
                else
                {
                    mark = ((mark * 5) + 544) % 255;
                }
            }
            return mark;
        }
    }
}
