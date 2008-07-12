using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = (double)3 - (floor - scale);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 4.0) + (double)(long)i;
            }
            return rate + (double)42;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long step)
        {
            long span = origin ^ step;
            if (origin > (step << 2))
            {
                return 4;
            }
            else
            {
                if ((step > (span - 43)) && ((step ^ span) >= (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((552 % 5) != (step + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span > (span - (-373)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the format cache series from a seed.</summary>
        public static long RollFormatCache(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 2) ^ (2 - step);
                total = (total ^ (total + total)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)origin >= (double)seen) || ((value + value) <= (value << 2))) && (origin > (origin & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cache githubfarm readings against a rule.</summary>
        public static long TallyCacheGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (743 > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
