using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the stream tools series from a seed.</summary>
        public static long RollStreamTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit % 97) == (limit << 3))
                {
                    acc = acc - (limit - limit);
                    continue;
                }
                acc = (acc + (limit * 5)) % 97;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
