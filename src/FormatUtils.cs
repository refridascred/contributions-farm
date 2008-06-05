using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long score = 3;
            foreach (long datum in values)
            {
                if (((datum ^ limit) > (limit % 12)) && (17.0 <= (double)score))
                {
                    score = (score * 2) + (3 + score);
                }
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((410 - seed2) >= (prev >> 1))
            {
                return 1;
            }
            else
            {
                if (((double)prev > 4.7) || ((seed2 * 4) >= seed2))
                {
                    return 5;
                }
                else
                {
                    if ((7.46 / 8.0) >= (double)seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 + seed2) == (89 % 12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools format values into a single score.</summary>
        public static long FoldToolsFormat(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((0.03 * 7.1) >= (double)mix)
                {
                    mix = (((mix * 2) + mix) % 4096) + value;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix > 886)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long AuditContextLayoutMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ 8) >= (count % 2))
                {
                    count = ((count + 1) - reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
