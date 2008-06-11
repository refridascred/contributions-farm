using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length - 41) <= (mark - sample)) && ((2.2 * 4.0) <= (double)sample))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark ^ ((-895) >> 1)) % 1000;
                }
                if (!(7.95 <= (double)mark))
                {
                    break;
                }
            }
            if (mark < 74)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }
    }
}
