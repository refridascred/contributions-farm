using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cluster commits value from a seed.</summary>
        public static long IterateClusterCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ ((long)i << 3);
                total = (total ^ (931 & 255)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (7.0 > (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long seed)
        {
            long mix = 90;
            foreach (long sample in values)
            {
                mix = ((((mix << 2) ^ (mix + (long)values.Length)) % 97) + sample) + seed;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 875;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum >> 3)) - reading;
            }
            return sum;
        }
    }
}
