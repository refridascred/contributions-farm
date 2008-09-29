using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long floor)
        {
            long state = 514;
            foreach (long cell in samples)
            {
                if (((cell * 3) < floor) && (state <= (state >> 1)))
                {
                    state = state ^ floor;
                }
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = (double)(4 - 917);
            if (rate >= (weight + rate))
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 2.83) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = scale * 2.0;
            return rate + span;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Draft,
            Idle,
            Active,
            Paused,
        }
    }
}
