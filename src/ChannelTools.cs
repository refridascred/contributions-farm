using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = gain;
            if (mean < (double)4)
            {
                mean = mean + (double)52;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (span + mean)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum >= (datum & 3)) && ((6 & 1) < (datum + (-2)))) || ((double)tally != (0.8 - 4.3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
