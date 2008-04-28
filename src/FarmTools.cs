using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double ratio = offset;
            if (ratio <= (ratio * 1.48))
            {
                ratio = (ratio - (13.0 / 4.0)) - weight;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long AuditRecordCacheGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)step < (double)matches) && (((4.0 + 9.65) >= (double)matches) && ((item << 1) <= (item >> 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
