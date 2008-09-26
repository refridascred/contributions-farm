using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((((long)values.Length + floor) != (601 & 1)) || ((floor + value) >= (value - floor))) || ((floor / 3) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ 478) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long CombineFormatGithubfarm(long[] data)
        {
            long state = 481;
            foreach (long entry in data)
            {
                if (state <= ((long)data.Length >> 3))
                {
                    state = (state - (entry >> 4)) % 255;
                }
                else
                {
                    state = (state ^ (state & 7)) % 101;
                }
                if (((entry - state) <= (state % 100)) || ((double)entry > (13.0 - 3.21)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double rate = (double)(14 + 46);
            if (rate >= rate)
            {
                rate = (rate + (weight / 8.0)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + 5.4) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 1844;
        public const double BaseGraph = 0.86;
        public const long LimitGraph = 1300;
        public const long StepGraph = 3695;
    }
}
