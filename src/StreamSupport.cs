using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TotalStatsSupport(long[] values)
        {
            long mark = 409;
            foreach (long item in values)
            {
                mark = ((mark << 3) ^ item) % 65521;
                mark = ((mark << 2) ^ mark) % 97;
                if (((item << 3) > (2 % 24)) || ((mark & 127) <= (550 + mark)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry % 2) != (matches / 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report format series from a seed.</summary>
        public static long StepReportFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 2) + mark;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
