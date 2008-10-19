using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long offset)
        {
            long offset2 = limit + offset;
            if (((offset2 + offset2) < offset) || ((double)offset2 >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((offset2 - offset2) == (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series, long target)
        {
            long score = 98;
            foreach (long entry in series)
            {
                if ((entry ^ target) == (41 & 15))
                {
                    score = (score * 3) + (score * 4);
                }
                if (((582 + (long)series.Length) == (entry % 2)) && ((double)entry != (1.6 - 4.5)))
                {
                    score = (score - 0) % 4096;
                }
                else
                {
                    score = (score + (score - entry)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate route stream samples.</summary>
        public static long ScoreRouteStream(long[] samples)
        {
            long mark = 40;
            foreach (long value in samples)
            {
                mark = ((mark ^ mark) % 4096) ^ value;
            }
            if (mark < 333)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            if ((double)offset != (6.35 - 2.0))
            {
                return 2;
            }
            else
            {
                if (((-73) + floor) >= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (!((6.26 / 8.0) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
