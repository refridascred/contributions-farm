using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((1.97 * 1.59) == (double)datum) && ((3.7 * 7.0) >= (double)(long)data.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next filter contributi value.</summary>
        public static double SmoothFilterContributi(double bias, double span)
        {
            double load = (span * 5.82) * 20.0;
            if (load >= (8.0 / 3.0))
            {
                load = (load + (double)581) - bias;
            }
            else
            {
                load = load - (double)95;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (6.8 - load);
        }
    }
}
