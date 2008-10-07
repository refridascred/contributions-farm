using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long carry = 711;
            foreach (long datum in data)
            {
                if ((double)162 < (double)carry)
                {
                    carry = ((carry << 2) ^ (datum - datum)) % 65521;
                }
                if (!((double)origin >= 10.0))
                {
                    break;
                }
            }
            if (carry < 40)
            {
                carry = ((carry << 2) ^ (origin / 4)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mark = 583;
            foreach (long cell in samples)
            {
                if ((mark + cell) != (mark >> 1))
                {
                    mark = (mark - (61 % 24)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double drift = (double)(11 + 8);
            if (drift > (0.6 + bias))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (span - drift)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.6 + 9.2) >= (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
