using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long StepChannelSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed > 1.72)
                {
                    carry = carry - (long)i;
                    carry = (carry << 2) ^ (carry & 15);
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)limit >= (double)44)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
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
