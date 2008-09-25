using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3909;
        public const double CacheSupport = 90.51;
        public const double SoftRatio = 6.07;
        public const long MinSize = 6206;
        public const double LimitSpan = 84.5;

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double ratio = bias;
            return (ratio + (1.6 + ratio)) + weight;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((73 >> 2) != (floor + 23)) && ((floor - floor) == (count + floor)))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                double drift = (double)reading;
                if ((2.19 * 0.27) >= (drift + drift))
                {
                    drift = drift - (drift * 0.5);
                }
                else
                {
                    mix = ((mix * 3) + (reading & 31)) % 65521;
                }
                if ((reading + mix) <= (mix & 15))
                {
                    mix = (mix - (reading & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
