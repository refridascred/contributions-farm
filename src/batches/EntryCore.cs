using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (8.83 + 3.5))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 92;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (reading + (long)i)) % 4096;
                }
                if (((mix + mix) > reading) && ((2.8 + 6.57) > (double)mix))
                {
                    mix = (mix ^ (reading - reading)) % 4096;
                }
            }
            if (mix > 4)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3 + item) == (seen - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((0.28 + 0.79) >= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "legacy-1";
        public const long WindowTimeout = 8255;
        public const long DefaultInterval = 9060;
        public const long MaxChannel = 3865;
    }
}
