using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long TallyNotesContributi(long[] values, long seed)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((double)0 == (double)mark)
                {
                    mark = ((mark + datum) % 65521) - seed;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2102;
        public const double IdleSize = 14.83;
        public const long BatchFormat = 9373;
        public const long IdleFormat = 2352;
        public const long MinSize = 3777;

        /// <summary>Check that every layout notes entry stays within the limit.</summary>
        public static bool CheckLayoutNotesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (16 >> 2)) + sample) - floor;
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 442;
            foreach (long reading in readings)
            {
                anchor = (anchor * 2) + (anchor ^ reading);
            }
            if (anchor > 572)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 65521;
        }
    }
}
