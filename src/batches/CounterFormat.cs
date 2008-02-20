using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (!!((double)mark <= (5.2 * 10.0)))
                {
                    mark = mark + (mark ^ step);
                    mark = (mark * 3) + (step % 100);
                }
                mark = (mark ^ (31 * 3)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double weight2 = (double)(237 + 360);
            return ((weight2 - (double)32) + weight) + span;
        }
    }
}
