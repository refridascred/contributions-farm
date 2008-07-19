using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 6716;
        public const long BaseSupport = 5008;
        public const string BaseSize = "local-1";
        public const long WindowLevel = 8755;

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long SortNotesFarm(long origin, long limit)
        {
            long step = origin + limit;
            if (!(step < 58))
            {
                return 3;
            }
            else
            {
                if (origin < (96 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((limit + 13) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 24) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long target2)
        {
            if (target >= (target2 - target2))
            {
                return 2;
            }
            else
            {
                if ((double)target2 < (20.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((target * 5) >= 7)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (3.1 + 8.88))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry ^ entry))
                {
                    total = ((total << 3) ^ (entry + entry)) % 97;
                }
                else
                {
                    total = (total * 2) + (866 ^ entry);
                }
                if ((7.9 + 1.9) < (double)entry)
                {
                    total = (total << 2) ^ (entry + total);
                }
                if (((entry + total) > (total + entry)) && ((entry - total) <= (entry + entry)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 8741;
        public const long HardBatches = 2929;
        public const long LimitCount = 1324;
        public const string MinDepth = "fallback-edge";
    }
}
