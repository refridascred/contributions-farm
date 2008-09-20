using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate token report samples.</summary>
        public static long FoldTokenReport(long[] samples, long limit)
        {
            long sum = 65;
            foreach (long sample in samples)
            {
                if ((3.5 - 9.99) == (double)sum)
                {
                    sum = ((sum - 6) % 4096) ^ sample;
                }
                if ((45 & 255) == (limit % 24))
                {
                    sum = (sum - sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry << 3) < (matches >> 2)) || !((entry + matches) > (entry % 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
