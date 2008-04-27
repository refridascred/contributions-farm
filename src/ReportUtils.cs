using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((datum + hits) >= target) || (hits > (datum + target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long WeighCacheAccount(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if (!((-40) > (reading - 1)))
                {
                    mix = ((mix * 5) + (9 ^ mix)) % 4096;
                }
                if ((mix + 621) != (long)readings.Length)
                {
                    break;
                }
            }
            if (mix > 45)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6.07 >= (double)hits) || !((hits << 3) < (0 >> 3)))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
