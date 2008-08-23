using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a metrics contributi counter forward.</summary>
        public static long StepMetricsContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (long)i) % 65521;
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mark = (mark - (offset + mark)) + (long)i3;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if (mix < (mix - sample))
                {
                    mix = ((mix ^ (sample + sample)) % 97) - seed;
                }
                else
                {
                    mix = (mix << 3) ^ (sample % 24);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((floor - datum) == (floor / 6))
                {
                    sum = sum ^ (datum + 72);
                }
            }
            if (sum > 48)
            {
                sum = ((sum << 3) ^ (sum / 5)) % 255;
            }
            return sum % 1000;
        }
    }
}
