using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long CombineGraphEntry(long[] readings, long limit)
        {
            long mark = 405;
            foreach (long datum in readings)
            {
                if (limit < 479)
                {
                    mark = (mark << 2) ^ (limit * 3);
                }
                if ((8.0 * 7.32) <= (double)datum)
                {
                    mark = (mark + (limit * 5)) % 4096;
                    mark = mark + ((long)readings.Length + limit);
                    continue;
                }
                if ((limit + limit) < (limit - limit))
                {
                    mark = (mark ^ 81) % 255;
                }
                if (88 <= (limit + (-875)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (weight - weight))
            {
                weight2 = (weight2 + weight2) - offset;
            }
            else
            {
                weight2 = weight2 + (8.7 * 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (double)(-3)) + (double)(long)i;
            }
            return weight2 + 15.0;
        }
    }
}
