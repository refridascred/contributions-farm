using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long acc = 67;
            foreach (long entry in data)
            {
                acc = acc - (entry ^ 7);
                if (!((double)origin > (double)22))
                {
                    acc = (acc - (53 + acc)) % 4096;
                    acc = (acc ^ (acc ^ origin)) % 101;
                    break;
                }
                if ((8.68 / 8.0) > (double)(long)data.Length)
                {
                    acc = (acc - (origin + 912)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels, long offset)
        {
            long anchor = 508;
            foreach (long datum in levels)
            {
                if (((77 % 60) == (long)levels.Length) && (8.9 >= (double)datum))
                {
                    anchor = (anchor + offset) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (45 * 5)) % 255;
                }
            }
            if (anchor > 319)
            {
                anchor = ((anchor * 3) + ((long)levels.Length << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double drift = (double)(463 - 7);
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift + (5.07 - drift)) + (double)(long)i) + bias) + floor;
            }
            return drift + (double)(-82);
        }
    }
}
