using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Closed,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count << 2) != (count - 44)))
                {
                    count = ((count + 1) ^ datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading + 287) <= matches) && (reading <= (reading >> 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long total = -244;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ bound) % 4096;
                total = ((total << 2) ^ (sample + (long)samples.Length)) % 101;
                if ((sample - bound) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
