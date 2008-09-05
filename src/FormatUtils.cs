using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel schema reading.</summary>
        public static double SmoothChannelSchema(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate * 2.57))
            {
                rate = (rate + (span / 2.0)) - scale;
            }
            return rate - (double)53;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((859 <= (long)i) || ((acc / 3) >= (limit >> 3)))
                {
                    acc = (acc << 3) ^ ((long)i & 7);
                }
                acc = (acc << 3) ^ acc;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = acc ^ ((long)i2 * 2);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two stats layout measurements.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (rate / 7.0)) + (double)(long)i) + floor;
            }
            return gain + (double)66;
        }

        /// <summary>Locate a batch githubfarm reading by value.</summary>
        public static long LookupBatchGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account context sample.</summary>
        public static long SeekAccountContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
