using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of support githubfarm entries.</summary>
        public static long DigestSupportGithubfarm(long[] values)
        {
            long mark = 36;
            foreach (long entry in values)
            {
                if ((mark + mark) >= (mark - mark))
                {
                    mark = (mark - ((long)values.Length / 9)) + entry;
                }
            }
            if (mark < 671)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long IteratePayloadNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (sum * 2)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "strict-edge";
        public const string LimitCluster = "local-edge";
        public const long SoftBudget = 277;
        public const double HardCluster = 48.72;
        public const long BaseCluster = 9258;
    }
}
