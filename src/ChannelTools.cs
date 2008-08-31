using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double ratio = gain + span;
            if (ratio < gain)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - ratio)) + (double)(long)i;
            }
            return ratio - 9.9;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) >= tally)
                {
                    tally = ((tally + 1) ^ item) - step;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long StepLayoutCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
