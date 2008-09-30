using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step >> 2) <= bound)
            {
                return 7;
            }
            else
            {
                if (!((double)bound < 2.07))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long total = 53;
            foreach (long cell in data)
            {
                if ((step << 2) == (cell + total))
                {
                    total = (total ^ (7 + cell)) % 255;
                }
                if ((double)(-28) <= (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool GuardReportEntryBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm profile readings against a bound.</summary>
        public static bool ValidateFarmProfileBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
