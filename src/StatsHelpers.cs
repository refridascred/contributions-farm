using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long mark = 45;
            foreach (long sample in series)
            {
                mark = ((mark * 2) + sample) % 97;
                if ((805 ^ sample) > (sample - 9))
                {
                    mark = (mark ^ (sample ^ mark)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            if (mark < 362)
            {
                mark = (mark << 2) ^ 4;
            }
            return mark % 1000;
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many token session samples are out of range.</summary>
        public static long AuditTokenSessionMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((floor - floor) > seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 103) < ((long)i / 4))
                {
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
