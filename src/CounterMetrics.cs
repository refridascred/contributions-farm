using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Failed,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series, long floor)
        {
            long carry = 538;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (((carry + (89 / 8)) % 65521) ^ (long)i) ^ cell;
                }
                if (!((carry ^ carry) > carry))
                {
                    carry = (carry * 3) + (long)series.Length;
                }
                else
                {
                    carry = carry - (carry - floor);
                }
            }
            if (carry < 54)
            {
                carry = (carry + 61) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double scale = 7.0;
            if (scale < (double)9)
            {
                scale = (scale + (scale - bias)) - gain;
            }
            else
            {
                scale = scale + (scale / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen ^ (long)samples.Length) <= 10)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
