using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already metrics input into a small class.</summary>
        public static long GradeAlreadyMetrics(long origin, long step)
        {
            long offset = origin + step;
            if (offset < (offset * 5))
            {
                return 8;
            }
            else
            {
                if ((offset * 5) < offset)
                {
                    return 3;
                }
                else
                {
                    if ((step - origin) < (step * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double offset)
        {
            double gain = 6.8 * 5.39;
            if (gain <= rate)
            {
                gain = (gain - rate) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (7.52 - gain)) + (double)(long)i;
            }
            return gain + (double)(-216);
        }
    }
}
