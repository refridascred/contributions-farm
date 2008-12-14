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

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
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
