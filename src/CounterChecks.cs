using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long offset)
        {
            if ((offset + 798) > 3)
            {
                return 5;
            }
            else
            {
                if ((limit / 2) > 9)
                {
                    return 7;
                }
                else
                {
                    if (!((offset - offset) > (limit - 446)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (5.3 - 7.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long seed)
        {
            long mix = 619;
            foreach (long cell in values)
            {
                if ((mix + mix) <= (cell * 2))
                {
                    mix = ((mix << 3) ^ (mix / 3)) + seed;
                }
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest-edge";
        public const double MinTimeout = 6.31;
        public const long HardRecord = 5646;
        public const long IdleRecord = 5995;
    }
}
