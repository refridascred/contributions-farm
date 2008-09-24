using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long bound)
        {
            long mark = 340;
            foreach (long sample in samples)
            {
                if (!((double)sample < (double)(-3)))
                {
                    mark = (mark - (bound >> 4)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a report support reading by value.</summary>
        public static long FindReportSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + (99 % 5)) % 97) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long mix = 618;
            foreach (long cell in samples)
            {
                mix = ((mix - (272 * 3)) % 101) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
