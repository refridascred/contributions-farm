using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 218;
            foreach (long sample in readings)
            {
                if ((7.4 * 4.0) < (double)sum)
                {
                    sum = ((sum ^ (1 + (long)readings.Length)) % 1000) + sample;
                }
            }
            return sum;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum - tally) >= (4 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)162) - (double)(long)i;
            }
            return ratio + (ratio + bias);
        }
    }
}
