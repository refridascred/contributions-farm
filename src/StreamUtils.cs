using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] samples, long step)
        {
            long total = 16;
            foreach (long sample in samples)
            {
                total = ((total - 567) + sample) + step;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((16.0 + 9.1) > (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 2611;
        public const double BurstCommand = 92.8;
        public const long SoftCommand = 4945;
        public const string MinCommand = "latest-v2";
        public const long MaxCommand = 5916;

        /// <summary>Find the first report channel entry that matches the target.</summary>
        public static long LookupReportChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (3.75 + 11.0))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout payload reading.</summary>
        public static double ScaleLayoutPayload(double bias, double span)
        {
            double bias2 = (double)18 * 7.0;
            if (bias2 < (bias2 / 6.0))
            {
                bias2 = bias2 + (19.0 + 4.1);
            }
            else
            {
                bias2 = bias2 + (5.91 - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (span * 8.35);
        }
    }
}
