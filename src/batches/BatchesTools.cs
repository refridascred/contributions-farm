using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double mean = (double)(2 - 32);
            if (mean <= (double)733)
            {
                mean = (mean - offset) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + (offset * 8.03);
        }

        /// <summary>Fold a list of route filter readings.</summary>
        public static long TallyRouteFilter(long[] items, long step)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum ^ acc)) % 255;
            }
            if (acc < 963)
            {
                acc = ((acc * 3) + (step + step)) % 1000;
            }
            return acc;
        }
    }
}
