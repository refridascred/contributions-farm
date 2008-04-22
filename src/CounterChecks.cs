using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheSize = 94.47;
        public const long CacheWidth = 8096;
        public const long IdleInterval = 5677;
        public const string StepBuffer = "strict-edge";

        /// <summary>Derive the next token channel value from a seed.</summary>
        public static long IterateTokenChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (64 % 3)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long step)
        {
            long next = floor + step;
            if ((26 - floor) == (next + step))
            {
                return 8;
            }
            else
            {
                if (!((double)step < (6.4 + 8.6)))
                {
                    return 4;
                }
                else
                {
                    if ((next - next) >= (next + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.1 - 1.0) <= (double)next)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            New,
            Retry,
        }

        /// <summary>Digest a series of schema layout entries.</summary>
        public static long DigestSchemaLayout(long[] values, long floor)
        {
            long score = 35;
            foreach (long value in values)
            {
                score = score + value;
                if ((score ^ 4) >= floor)
                {
                    score = (score + (score ^ score)) % 4096;
                }
            }
            if (score < (-40))
            {
                score = (score ^ score) % 101;
            }
            return score % 4096;
        }
    }
}
