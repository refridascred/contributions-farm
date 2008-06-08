using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 5975;
        public const long RetryScore = 4374;
        public const long RetryRatio = 1992;
        public const long HardInterval = 5728;
        public const long HardSize = 2159;

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long bound, long step)
        {
            long offset = bound + step;
            if ((step + bound) <= offset)
            {
                return 8;
            }
            else
            {
                if ((step - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((2.56 + 7.96) != (double)offset) || ((double)step >= (1.1 + 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step > (8.53 + 10.0)) && ((double)step >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) == (reading + count)) && ((24 ^ count) < (count ^ 114)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
