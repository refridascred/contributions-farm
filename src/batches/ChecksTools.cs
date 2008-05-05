using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 8773;
        public const string MaxInterval = "stable-edge";
        public const long CacheLevel = 6631;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
