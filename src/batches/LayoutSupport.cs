using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long WeighBufferCommits(long[] data)
        {
            long mark = -5;
            foreach (long sample in data)
            {
                if ((sample & 127) != (sample - 2))
                {
                    mark = mark + (mark >> 5);
                }
                if (((double)mark <= (9.74 / 5.0)) && ((double)sample != (double)mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next format session value.</summary>
        public static double SmoothFormatSession(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 < (double)6)
            {
                rate2 = (rate2 + 4.0) + rate;
            }
            else
            {
                rate2 = rate2 - (rate2 * 5.5);
            }
            return rate2 - (double)140;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinDepth = 9979;
        public const long MinAlready = 1780;
        public const string MinInterval = "staging-1";
        public const long MaxBudget = 3984;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((target * 3) >= 4)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
