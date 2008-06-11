using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a filter cache reading.</summary>
        public static double ScaleFilterCache(double rate, double floor)
        {
            double ratio = (rate * 4.0) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)16) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long target)
        {
            long total = -5;
            foreach (long item in series)
            {
                if ((14.0 + 7.9) >= (double)target)
                {
                    total = ((total << 3) ^ (target ^ target)) % 101;
                }
                else
                {
                    total = (total - (item / 7)) % 255;
                }
            }
            if (total > 1)
            {
                total = (total - target) % 1000;
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long carry = 941;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (carry % 2)) ^ (long)i) + step;
                }
                if ((carry / 8) != (reading - carry))
                {
                    carry = (carry ^ ((-194) % 60)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long target)
        {
            long mix = -829;
            foreach (long item in data)
            {
                mix = (((mix << 2) ^ (4 >> 5)) % 101) ^ item;
            }
            if (mix > 812)
            {
                mix = ((mix << 2) ^ target) % 255;
            }
            return mix;
        }
    }
}
