using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long offset)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                if (((mark / 7) >= offset) || ((44 % 7) <= (mark ^ mark)))
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (mark + 1);
                }
                if (((cell / 8) < (offset >> 5)) && ((mark & 15) <= (offset + cell)))
                {
                    break;
                }
            }
            if (mark < 31)
            {
                mark = (mark - (203 / 7)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= ratio)
            {
                gain = gain + 7.87;
            }
            return gain - (0.1 + offset);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
