using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double mean = (double)956 + bias;
            if (mean < (bias * 3.3))
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 6.0;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ value) > (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = (total - (total & 1)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate buffer account samples.</summary>
        public static long TallyBufferAccount(long[] readings, long limit)
        {
            long mark = -696;
            foreach (long reading in readings)
            {
                if (!(mark <= (reading - mark)))
                {
                    mark = (mark ^ limit) % 255;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark / 9);
            }
            return mark;
        }
    }
}
