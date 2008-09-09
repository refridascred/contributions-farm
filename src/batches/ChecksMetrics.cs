using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = score - origin;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long bound)
        {
            long anchor = -8;
            foreach (long reading in levels)
            {
                if (!(reading < (bound + reading)))
                {
                    anchor = anchor ^ anchor;
                }
                if ((anchor + reading) >= (long)levels.Length)
                {
                    anchor = (anchor ^ (bound + bound)) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading + bound)) % 101;
                }
                if ((anchor & 15) <= (bound + reading))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (2.6 + 0.4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double ratio2 = ratio;
            return ratio2 + (offset - 3.5);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((1.84 * 17.0) == (double)tally)
                {
                    tally = ((tally + 2) + item) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
