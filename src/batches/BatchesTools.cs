using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long sum = 173;
            foreach (long entry in data)
            {
                sum = sum ^ entry;
                if (((sum + sum) < sum) && ((12.0 / 5.0) != (double)entry))
                {
                    sum = sum - (80 + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two context farm measurements.</summary>
        public static double ProjectContextFarm(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + 17.0) + (double)(long)i) + ratio;
            }
            return weight - weight;
        }
    }
}
