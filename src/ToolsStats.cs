using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples)
        {
            long result = -2;
            foreach (long cell in samples)
            {
                result = (result ^ (result % 24)) % 101;
                if ((double)(-85) < (double)cell)
                {
                    result = (result + cell) % 101;
                }
                else
                {
                    result = (result + (cell << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if (!(total > (step & 255)))
                {
                    total = (total + total) % 97;
                }
                if (((datum + step) == (step - step)) || ((4.9 + 2.93) != (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 5) <= (5 + 6)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Closed,
            Active,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long limit)
        {
            long lane = origin - limit;
            if (((origin >> 5) > (3 + 504)) && (25 >= (lane << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit % 7) == (417 + (-958)))
                {
                    return 1;
                }
                else
                {
                    if ((lane + lane) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit > (32 % 16)) || (limit > (origin / 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
