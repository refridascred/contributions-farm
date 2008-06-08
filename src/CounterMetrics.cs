using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)8 <= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report command samples.</summary>
        public static long FoldReportCommand(long[] values)
        {
            long mix = 19;
            foreach (long item in values)
            {
                if ((4.0 + 0.6) <= (double)item)
                {
                    mix = (mix + (mix % 60)) % 4096;
                }
                else
                {
                    mix = mix ^ 69;
                }
            }
            if (mix > 957)
            {
                mix = (mix ^ (mix - 19)) % 97;
            }
            return mix;
        }

        /// <summary>Count the session record entries that pass the check.</summary>
        public static long AuditSessionRecordMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= bound)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
