using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 9538;
        public const long DefaultFarm = 471;
        public const long RetryScore = 7284;
        public const long MinFarm = 341;
        public const long RetryFarm = 6444;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double mean = offset;
            if (mean > (double)2)
            {
                mean = (mean - (mean * 20.0)) - gain;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (offset / 8.0);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) - reading;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
