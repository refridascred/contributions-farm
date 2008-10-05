using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Locked,
            Closed,
            New,
        }

        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long PairCommitsBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools token series from a seed.</summary>
        public static long RollToolsToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ (acc - (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
