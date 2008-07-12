using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate route buffer samples.</summary>
        public static long DigestRouteBuffer(long[] series, long step)
        {
            long anchor = 0;
            foreach (long cell in series)
            {
                anchor = (anchor * 4) + (step ^ cell);
                if (!((anchor / 6) <= (cell & 255)))
                {
                    break;
                }
            }
            if (anchor > 19)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 4709;
        public const long MinSize = 9143;
        public const string RetryGraph = "fallback-edge";
        public const string SoftGraph = "primary-v2";
        public const long MinGraph = 9682;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= bias)
            {
                gain2 = (gain2 - gain2) - gain;
            }
            else
            {
                gain2 = gain2 - (20.0 * 2.5);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (1.0 * 8.0)) + (double)(long)i;
            }
            return gain2 + 8.0;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long anchor = 29;
            foreach (long entry in levels)
            {
                anchor = ((anchor ^ (limit % 7)) % 97) ^ entry;
            }
            return anchor % 97;
        }
    }
}
