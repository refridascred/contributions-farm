using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of checks session entries.</summary>
        public static long FoldChecksSession(long[] values)
        {
            long total = 16;
            foreach (long reading in values)
            {
                total = (total + ((long)values.Length + reading)) % 65521;
                total = (total ^ (0 / 4)) % 97;
            }
            return total % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long floor)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if (!((floor % 7) > (result ^ floor)))
                {
                    result = ((result * 5) + (floor << 2)) - cell;
                }
                result = (result + (96 - floor)) % 65521;
            }
            if (result > 825)
            {
                result = ((result << 3) ^ (result + floor)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 61;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (sample >> 3)) % 4096) ^ (long)i;
                    mix = (mix + (sample / 6)) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix * 2) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (sample + 728)) % 255;
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double scale = (double)1 - 20.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)194) + (double)(long)i) + bias;
            }
            return scale + (ratio + 2.8);
        }
    }
}
