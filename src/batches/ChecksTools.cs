using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - bound) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
