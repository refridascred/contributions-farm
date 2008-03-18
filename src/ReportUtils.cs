using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double ratio = offset * 2.9;
            if (ratio > (double)5)
            {
                ratio = ratio - (ratio + rate);
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (rate + 2.25);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((11.0 - 5.8) > (double)value)
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

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mark = 64;
            foreach (long sample in values)
            {
                if ((double)mark != (1.02 - 19.0))
                {
                    mark = (((mark << 2) ^ (mark % 8)) % 97) ^ sample;
                }
            }
            return mark % 97;
        }
    }
}
