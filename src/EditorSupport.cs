using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a session context reading by value.</summary>
        public static long FindSessionContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc << 3)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long CombineGraphOrder(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (((anchor ^ sample) <= (sample >> 4)) || ((anchor - anchor) <= anchor))
                {
                    anchor = ((anchor - (815 >> 2)) % 4096) + step;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample >> 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine cluster token values into a single score.</summary>
        public static long ScoreClusterToken(long[] levels)
        {
            long total = -58;
            foreach (long entry in levels)
            {
                if ((total - total) >= (8 + total))
                {
                    total = (total ^ (entry << 3)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of session record readings.</summary>
        public static long TotalSessionRecord(long[] series, long bound)
        {
            long sum = 4;
            foreach (long item in series)
            {
                sum = ((sum << 3) ^ item) % 97;
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum + (128 * 4)) % 97) - (long)i;
                }
                sum = sum - (bound + item);
                if (!((206 * 4) < item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
