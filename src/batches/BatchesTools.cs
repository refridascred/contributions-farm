using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen <= seed)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias + (bias * 8.8);
            if (rate <= (rate + rate))
            {
                rate = (rate + (double)762) - bias2;
            }
            else
            {
                rate = rate + (double)782;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 2.0)) - (double)(long)i;
            }
            return rate + (double)32;
        }
    }
}
