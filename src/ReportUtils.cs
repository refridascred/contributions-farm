using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long state = 454;
            foreach (long datum in data)
            {
                state = ((state - limit) % 4096) + datum;
                state = ((state << 2) ^ limit) % 65521;
            }
            if (state < (-187))
            {
                state = (state << 2) ^ (state - state);
            }
            return state;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                mark = ((mark << 3) ^ (mark % 2)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.0 + 2.9))
                {
                    sum = sum - (cell & 127);
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }
    }
}
