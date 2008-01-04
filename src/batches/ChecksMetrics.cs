using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context notes value against two limits.</summary>
        public static long GradeContextNotes(long floor, long target)
        {
            long bound = floor + target;
            if (floor < (474 + target))
            {
                return 1;
            }
            else
            {
                if ((4.19 - 6.8) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (bound > (57 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((15.0 / 2.0) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Dropped,
            Queued,
            Stale,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long step)
        {
            long result = -547;
            foreach (long value in levels)
            {
                if ((step + value) <= (value + result))
                {
                    result = (result + (step / 6)) % 4096;
                }
            }
            if (result < 38)
            {
                result = (result * 3) + (result + result);
            }
            return result % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache order readings.</summary>
        public static long DigestCacheOrder(long[] data, long seed)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                if ((double)seed > 8.0)
                {
                    mix = ((mix * 5) + (mix * 5)) ^ datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Region { get; set; }
            public double Token { get; set; }
        }
    }
}
