using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((4 - floor) > ((-1) + (long)i))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry & 31)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
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

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long anchor = 234;
            foreach (long datum in samples)
            {
                if ((double)seed >= (0.6 * 2.54))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                anchor = anchor - (datum * 2);
            }
            return anchor % 4096;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings)
        {
            long score = 86;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (sample + 290);
                score = ((score * 2) + (score + score)) % 65521;
                if (((score / 5) > (score >> 3)) && ((double)(long)readings.Length < (1.5 / 7.0)))
                {
                    break;
                }
            }
            return score;
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
