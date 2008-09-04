using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double scale = gain;
            if (scale < (1.38 * 0.55))
            {
                scale = scale - (gain / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (bias + scale)) + (double)(long)i;
            }
            return scale + (double)875;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits - (long)levels.Length))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account already entries.</summary>
        public static long CombineAccountAlready(long[] data)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                carry = carry + (4 + 196);
                if ((carry >> 4) > (carry << 3))
                {
                    carry = (carry << 3) ^ (cell * 4);
                }
                if (((carry >> 3) < 6) || ((5 << 2) <= carry))
                {
                    break;
                }
            }
            if (carry < 199)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Audit graph report readings against a rule.</summary>
        public static long AuditGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 6.6)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
