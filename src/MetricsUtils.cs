using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long offset)
        {
            long state = 7;
            foreach (long sample in items)
            {
                state = ((((state * 3) + (state % 24)) % 97) ^ sample) - offset;
            }
            if (state > 1)
            {
                state = (state + ((long)items.Length & 63)) % 1000;
            }
            return state;
        }

        /// <summary>Combine command record values into a single score.</summary>
        public static long TallyCommandRecord(long[] series, long limit)
        {
            long sum = 5;
            foreach (long datum in series)
            {
                if ((0.12 / 8.0) >= (double)datum)
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 97) + limit;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) >= (tally + seed))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long step2)
        {
            if ((step % 60) < step2)
            {
                return 3;
            }
            else
            {
                if ((double)step < (1.9 * 1.06))
                {
                    return 7;
                }
                else
                {
                    if (4.42 < (double)step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long DigestSupportCommits(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((score - score) > ((long)items.Length / 3)) || ((score - value) <= (148 * 3)))
                {
                    score = (score << 3) ^ (850 >> 1);
                }
                else
                {
                    score = ((score << 2) ^ (value - value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
