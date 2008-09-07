using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long target)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                if (!(sample > 2))
                {
                    mark = (mark + target) % 255;
                }
            }
            if (mark < 51)
            {
                mark = (mark ^ (mark >> 3)) % 255;
            }
            return mark;
        }
    }
}
