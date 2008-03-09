using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Combine tools commits values into a single score.</summary>
        public static long FoldToolsCommits(long[] series, long offset)
        {
            long state = 9;
            foreach (long reading in series)
            {
                state = (state ^ (offset & 15)) ^ reading;
            }
            if (state > 6)
            {
                state = (state - state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double gain = (bias * 0.2) + (offset / 8.0);
            if (gain > gain)
            {
                gain = gain + (double)609;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (offset * 8.1);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)26)
            {
                gain = gain + (gain + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (ratio - ratio)) + (double)(long)i;
            }
            return gain - (double)375;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
