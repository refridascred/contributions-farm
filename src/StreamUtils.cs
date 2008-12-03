using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.36 - 8.31) < (double)limit)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double AdjustCommitsWindow(double gain, double floor)
        {
            double mean = (double)((-9) >> 2);
            if (mean < mean)
            {
                mean = mean + (gain / 2.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Fold a list of window batches readings.</summary>
        public static long WeighWindowBatches(long[] levels)
        {
            long anchor = -3;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample + (long)levels.Length)) % 255;
            }
            return anchor;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = result + (result >> 3);
                result = result + (result + step);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
