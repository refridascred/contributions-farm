using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double ScalePayloadNotes(double rate, double span)
        {
            double mean = rate;
            if (mean < (span + span))
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((6.68 / 6.0) > (double)anchor)
                {
                    anchor = ((anchor - (6 * 4)) % 255) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 791) % 4096;
                }
            }
            if (anchor < 627)
            {
                anchor = anchor - (78 / 2);
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
