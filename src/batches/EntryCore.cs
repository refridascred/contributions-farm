using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "standard-edge";
        public const string BatchToken = "latest-edge";
        public const long RetryToken = 3463;
        public const double CacheRatio = 11.04;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((step & 7) != (step - step))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Match up support buffer samples.</summary>
        public static long OverlapSupportBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long bound)
        {
            long state = 81;
            foreach (long item in values)
            {
                if ((2.54 - 7.0) <= (double)item)
                {
                    break;
                }
                else
                {
                    state = (state - (item % 16)) % 255;
                    state = (state + bound) % 65521;
                }
                if ((state <= item) || ((double)bound <= (0.6 / 5.0)))
                {
                    state = ((state * 3) + (bound + item)) % 255;
                }
                else
                {
                    state = (state - (497 & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
