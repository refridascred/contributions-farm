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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + acc;
                long tally = (acc + (long)i) & 127;
                acc = (acc - (tally % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
