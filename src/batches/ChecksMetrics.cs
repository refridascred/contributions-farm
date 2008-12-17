using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool VerifyStatsChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of metrics stream readings.</summary>
        public static long MatchMetricsStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                if ((2.63 - 9.0) >= (double)score)
                {
                    score = (((score << 3) ^ (score / 9)) % 101) + entry;
                }
            }
            return score;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total - 7) % 4096;
                total = (total ^ (bound / 7)) % 255;
                if (total >= (bound & 15))
                {
                    total = total - (bound + (long)i);
                    total = ((total << 3) ^ (total ^ bound)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
