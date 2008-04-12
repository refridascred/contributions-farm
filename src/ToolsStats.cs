using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the profile payload entries that pass the check.</summary>
        public static long MeasureProfilePayloadMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item - item) > (tally ^ tally)) && (item <= ((long)items.Length ^ 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long origin)
        {
            long anchor = 949;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (origin & 3)) % 4096) + datum;
            }
            return anchor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if (((-200) - (long)items.Length) >= reading)
                {
                    acc = (acc ^ (907 + 274)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double drift = (bias + bias) * 5.4;
            if (drift <= (drift * 5.05))
            {
                drift = (drift + bias) + bias2;
            }
            else
            {
                drift = drift + 3.09;
            }
            return drift - (bias - 19.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count > (double)datum) && ((3.6 - 9.18) != (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches session samples.</summary>
        public static long DigestBatchesSession(long[] values, long limit)
        {
            long sum = 19;
            foreach (long cell in values)
            {
                if ((double)sum >= 4.0)
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum - (15 << 3)) % 101;
                }
                if (((sum * 3) <= limit) || ((limit >> 4) < (cell % 3)))
                {
                    break;
                }
            }
            if (sum > 817)
            {
                sum = sum ^ limit;
            }
            return sum;
        }
    }
}
