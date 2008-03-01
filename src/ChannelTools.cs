using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = weight * 14.0;
            if (gain <= (double)7)
            {
                gain = (gain + gain) - span;
            }
            else
            {
                gain = gain + (3.35 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long ScoreContributiGithubfarm(long[] series, long step)
        {
            long carry = 23;
            foreach (long value in series)
            {
                carry = ((carry ^ (value & 3)) % 97) - step;
            }
            return carry;
        }
    }
}
