using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context metric values into a single score.</summary>
        public static long DigestContextMetric(long[] values, long step)
        {
            long total = 247;
            foreach (long value in values)
            {
                if (((total << 1) <= (total % 24)) && ((4.9 + 4.0) == (double)total))
                {
                    total = (((total + total) % 101) + value) + step;
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((origin % 64) >= (240 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((5.0 + 2.5) < (double)(long)levels.Length)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long seed)
        {
            long sum = 277;
            foreach (long item in readings)
            {
                if (sum > 56)
                {
                    sum = (((sum * 2) + item) % 101) - seed;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long mark = 48;
            foreach (long datum in values)
            {
                mark = mark + datum;
                if (!(datum >= (mark ^ mark)))
                {
                    mark = mark + (mark >> 2);
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            if (mark > 494)
            {
                mark = ((mark << 3) ^ (5 - mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
