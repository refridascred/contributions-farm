using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long target2)
        {
            long gap = target - target2;
            if (37 > (675 - target))
            {
                return 2;
            }
            else
            {
                if (gap >= (target2 + 983))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long step)
        {
            long lane = offset + step;
            if ((offset + offset) <= (lane + offset))
            {
                return 2;
            }
            else
            {
                if (((0 << 2) <= (lane & 63)) || ((step - lane) >= (-6)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > 3.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (lane <= (4 % 3))
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

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 58.73;
        public const double BurstFactor = 34.04;
        public const long WindowSession = 8313;
        public const double HardRatio = 7.03;

        /// <summary>Blend two support command measurements.</summary>
        public static double ProjectSupportCommand(double rate, double span)
        {
            double mean = span;
            if (mean > (double)(-62))
            {
                mean = (mean - mean) - rate;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean - (span + mean);
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
