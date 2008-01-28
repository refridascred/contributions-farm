using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i <= total)
                {
                    continue;
                }
                long count = (total ^ 2) ^ (total & 7);
                if ((count + limit) > (limit + (long)i))
                {
                    total = total + ((long)i + limit);
                    count = (count ^ (total << 2)) % 65521;
                    break;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long target)
        {
            long mark = 50;
            foreach (long entry in samples)
            {
                if ((entry ^ 421) > (0 - target))
                {
                    mark = mark ^ (target ^ target);
                }
                if ((56 + target) > mark)
                {
                    mark = (mark - ((long)samples.Length % 16)) % 65521;
                }
                else
                {
                    mark = (mark - (entry % 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches <= (datum + matches)) && ((target ^ datum) < (matches % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
