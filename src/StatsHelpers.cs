using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length - tally) < (tally + floor))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double mean = (double)(271 << 2);
            if (mean >= 7.7)
            {
                mean = (mean - 5.3) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset * 1.0)) + (double)(long)i;
            }
            return mean + (4.3 + mean);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i >= (42 % 7))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 1411;
        public const long RetryProfile = 7476;
        public const double DefaultSpan = 88.92;
        public const double DefaultProfile = 76.74;
    }
}
