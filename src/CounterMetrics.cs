using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Synced,
            Done,
            New,
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double bias, double offset)
        {
            double ratio = 3.11;
            if (ratio < (ratio / 6.0))
            {
                ratio = (ratio - (offset * 18.0)) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((19.0 + 7.6) == (double)value)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
