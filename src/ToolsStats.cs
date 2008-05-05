using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up metric commits samples.</summary>
        public static long OverlapMetricCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stream account counter forward.</summary>
        public static long RollStreamAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (-416)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "latest-1";
        public const double MaxCount = 5.41;
        public const long StepSize = 4077;
        public const long CacheRoute = 9136;
        public const string IdleRoute = "staging";

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            long diff = target + floor;
            if ((target * 3) < floor)
            {
                return 8;
            }
            else
            {
                if ((diff - diff) > (diff + target))
                {
                    return 3;
                }
                else
                {
                    if (((diff - floor) > (floor * 4)) || ((diff + diff) != (3 >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long DigestSessionChannel(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (!((2.0 * 5.0) <= (double)score))
                {
                    score = (score + 4) + sample;
                }
            }
            return score % 4096;
        }
    }
}
