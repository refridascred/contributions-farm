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

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
