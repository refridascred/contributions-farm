using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long mix = 961;
            foreach (long reading in series)
            {
                mix = (((mix << 2) ^ (floor << 3)) % 101) + reading;
            }
            return mix;
        }

        /// <summary>Locate a cluster command reading by value.</summary>
        public static long FindClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next command editor value from a seed.</summary>
        public static long RollCommandEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((sum > (5 ^ sum)) && (((long)i - (long)i) >= (57 << 2)))
                {
                    sum = ((sum << 3) ^ (7 - floor)) % 65521;
                    sum = sum + (sum + (long)i);
                    continue;
                }
                sum = sum ^ (sum >> 5);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
