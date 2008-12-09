using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up counter already samples.</summary>
        public static long OverlapCounterAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long limit)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                if ((0 + item) < (limit + item))
                {
                    carry = (carry + (item + limit)) % 1000;
                }
                else
                {
                    carry = (carry ^ limit) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 5.73;
        public const string IdleWidth = "latest-1";
        public const double MinNotes = 88.78;
        public const long HardBudget = 7104;

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            long next = limit + seed;
            if ((double)seed != (1.0 - 0.57))
            {
                return 4;
            }
            else
            {
                if ((84 - next) != (98 & 255))
                {
                    return 7;
                }
                else
                {
                    if ((next - next) <= (seed / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(((-9) << 2) <= (seed + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
