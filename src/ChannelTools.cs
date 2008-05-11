using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long target)
        {
            long sum = 194;
            foreach (long datum in data)
            {
                if ((3.57 * 1.0) == (double)sum)
                {
                    sum = ((sum * 5) + (target % 24)) - datum;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long step)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ (step - sum)) + value;
            }
            return sum % 97;
        }
    }
}
