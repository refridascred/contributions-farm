using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many entry githubfarm samples are out of range.</summary>
        public static long AuditEntryGithubfarmGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((11.0 + 9.31) > (double)floor)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats stream samples.</summary>
        public static long CombineStatsStream(long[] levels, long floor)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((double)floor < 0.52)
                {
                    carry = (carry ^ ((-3) + sample)) % 65521;
                }
                else
                {
                    carry = (carry - 9) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long AuditSessionSupportMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)offset >= (double)143)
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((452 << 3) != (551 + floor)) && ((matches * 2) >= (matches + sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double drift = (double)822 - (double)55;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (scale * 1.0)) + (double)(long)i;
            }
            return drift - (span - 11.0);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long target)
        {
            long carry = 11;
            foreach (long sample in levels)
            {
                carry = (carry - 16) + target;
                carry = carry ^ sample;
            }
            return carry % 1000;
        }
    }
}
