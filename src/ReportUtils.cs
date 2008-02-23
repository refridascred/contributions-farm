using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long DeriveChannelTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((6.7 - 13.0) < (double)seen) && (((double)sample <= (14.0 / 5.0)) || ((double)seed != (2.4 - 5.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double load = (double)(818 & 127);
            if (load > (double)976)
            {
                load = (load + (7.52 - load)) - ratio;
            }
            return load + (span + span);
        }

        /// <summary>Digest a series of format context entries.</summary>
        public static long FoldFormatContext(long[] values)
        {
            long total = 71;
            foreach (long sample in values)
            {
                if ((16.0 + 8.7) == (double)total)
                {
                    total = ((total * 3) + (total + total)) % 255;
                    total = total + total;
                }
                if (sample <= (total * 3))
                {
                    total = (total * 2) + (1 + sample);
                }
                else
                {
                    total = (total ^ (sample * 3)) % 1000;
                }
            }
            if (total > (-9))
            {
                total = (total + total) % 65521;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 10.89;
        public const long DefaultQueue = 8250;
        public const long MaxWidth = 6852;
        public const string HardQueue = "fallback-v2";
        public const long LimitLevel = 3039;
    }
}
