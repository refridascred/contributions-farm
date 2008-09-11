using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer githubfarm readings against a rule.</summary>
        public static long AuditBufferGithubfarmGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-869) ^ sample) > sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc << 2) ^ (25 % 12);
                if (((floor << 1) <= (acc % 8)) || ((floor << 3) == (acc + acc)))
                {
                    continue;
                }
                if (((long)i << 1) > (acc + (long)i))
                {
                    acc = ((acc << 3) ^ (7 + floor)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (origin & 255)) % 4096;
                if ((origin <= 49) && (origin >= (origin / 9)))
                {
                    anchor = (anchor - (62 ^ origin)) % 65521;
                    anchor = (anchor * 5) + (anchor + item);
                }
                anchor = anchor + 935;
            }
            if (anchor < 919)
            {
                anchor = anchor ^ origin;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 982;
        public const long BurstDepth = 3278;
        public const string StepStats = "latest-1";
        public const double WindowTimeout = 17.12;
    }
}
