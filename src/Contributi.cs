using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double weight = (3.0 / 9.0) - 9.25;
            if (weight <= (weight - weight))
            {
                weight = (weight + (weight * 1.3)) - floor;
            }
            else
            {
                weight = weight - (15.0 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.95 * 0.12)) - (double)(long)i;
            }
            return weight + 6.3;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample + hits) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph commits value from a seed.</summary>
        public static long IterateGraphCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i < (mix - 7))
                {
                    break;
                }
                mix = (mix ^ ((long)i + (long)i)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
