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

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long ScoreChannelFarm(long[] samples, long step)
        {
            long score = 975;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (score >> 5)) % 1000) + cell) + step;
            }
            return score % 65521;
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
