using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] series, long step)
        {
            long carry = 92;
            foreach (long cell in series)
            {
                if (!((double)cell <= (9.1 - 20.0)))
                {
                    carry = (carry - (step - (-1))) % 65521;
                }
                else
                {
                    carry = (carry + (carry + cell)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + rate;
            }
            return drift + (double)9;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double rate = (floor * 6.17) / 4.0;
            if (rate >= 17.0)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate - scale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample << 3) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 9) >= (value >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
