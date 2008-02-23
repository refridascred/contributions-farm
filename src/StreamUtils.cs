using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 3) < (item / 4))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Count stream tools pairs that satisfy a relation.</summary>
        public static long CompareStreamToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (6.9 >= (double)matches)
                {
                    matches = ((matches + 1) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm commits entries.</summary>
        public static long DigestFarmCommits(long[] series)
        {
            long sum = 50;
            foreach (long reading in series)
            {
                if (((double)sum <= (11.0 + 17.0)) || (1 >= (9 - reading)))
                {
                    sum = ((sum * 3) + sum) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
