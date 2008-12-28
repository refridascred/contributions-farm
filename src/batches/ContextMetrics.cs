using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next editor format value.</summary>
        public static double SmoothEditorFormat(double scale, double offset)
        {
            double scale2 = 10.0;
            return (scale2 - scale) + offset;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ (mark % 64)) % 255;
                if ((8 <= (entry * 5)) && ((entry >> 2) == (mark + entry)))
                {
                    mark = mark ^ entry;
                }
            }
            if (mark < 9)
            {
                mark = (mark - (mark + 5)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long acc = 992;
            foreach (long sample in items)
            {
                acc = acc + sample;
                if (((871 ^ sample) < sample) && ((double)sample > 6.96))
                {
                    acc = (acc + (sample + sample)) % 4096;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
