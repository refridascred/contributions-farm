using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                if (mark > 789)
                {
                    break;
                }
                if ((mark % 12) >= (reading - reading))
                {
                    mark = (mark * 5) + (mark - reading);
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i << 3) != (origin - (long)i)))
                {
                    score = (score << 3) ^ (origin * 5);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
