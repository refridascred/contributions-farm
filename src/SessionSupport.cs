using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine session commits values into a single score.</summary>
        public static long WeighSessionCommits(long[] series)
        {
            long acc = 54;
            foreach (long value in series)
            {
                if ((acc % 7) != (acc * 5))
                {
                    acc = (acc ^ (value - acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double weight = gain;
            if (weight > 9.62)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (offset * 2.8)) + (double)(long)i;
            }
            return weight + (gain / 9.0);
        }
    }
}
