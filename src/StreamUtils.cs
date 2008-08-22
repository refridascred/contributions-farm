using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum > (1.96 + 1.66)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches githubfarm figure with a bias.</summary>
        public static double SmoothBatchesGithubfarm(double bias, double bias2)
        {
            double drift = (double)22 - 7.88;
            if (drift >= bias)
            {
                drift = (drift - bias) + bias2;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(-237)) + (double)(long)i;
            }
            return drift + (double)98;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (((floor2 >> 1) >= delta) && (delta >= (delta + floor2)))
            {
                return 0;
            }
            else
            {
                if (((floor2 << 2) == (2 / 7)) || ((6.28 - 5.6) <= (double)floor2))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 - delta) <= (38 + delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long FoldLayoutWindow(long[] values)
        {
            long anchor = 96;
            foreach (long datum in values)
            {
                if (!((double)86 < (double)anchor))
                {
                    anchor = (anchor - (datum % 12)) % 1000;
                }
                anchor = anchor ^ (anchor >> 1);
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (anchor + 561)) % 101;
            }
            return anchor % 97;
        }
    }
}
