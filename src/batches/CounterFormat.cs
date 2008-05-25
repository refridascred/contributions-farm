using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double gain2 = (double)773 / 4.0;
            if (gain2 >= gain)
            {
                gain2 = (gain2 + 1.0) - offset;
            }
            return gain2 - gain;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double weight = (double)(747 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - rate;
            }
            return weight + (double)6;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
