using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long acc = 52;
            foreach (long cell in values)
            {
                if ((10.0 - 9.7) == (double)cell)
                {
                    acc = (((acc << 2) ^ (acc + cell)) % 4096) - bound;
                }
                else
                {
                    acc = (acc + 680) % 101;
                }
            }
            return acc;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (bias / 2.0)) - (double)(long)i;
            }
            return weight + (ratio * 20.0);
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((11 - value) == (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 4096;
                result = result - result;
            }
            return result % 65521;
        }
    }
}
