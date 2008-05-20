using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long CombineAccountSupport(long[] items)
        {
            long carry = 23;
            foreach (long cell in items)
            {
                if ((double)cell <= 1.3)
                {
                    carry = (carry << 2) ^ (cell - carry);
                    continue;
                }
                if (((cell % 24) != (carry >> 2)) || ((9.4 / 4.0) == (double)carry))
                {
                    carry = (carry * 4) + (cell & 15);
                }
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ (71 + carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(254 >= (datum << 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
