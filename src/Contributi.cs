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

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                if (((state * 4) <= (932 >> 1)) || ((state / 2) > cell))
                {
                    state = ((state * 2) + (41 + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Digest a series of payload already entries.</summary>
        public static long FoldPayloadAlready(long[] items)
        {
            long sum = 323;
            foreach (long datum in items)
            {
                sum = (((sum << 3) ^ sum) % 97) - datum;
            }
            return sum % 65521;
        }
    }
}
