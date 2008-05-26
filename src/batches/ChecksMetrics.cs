using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const double MaxStats = 30.5;
        public const long SoftLevel = 199;

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + 5) < matches)
                {
                    matches = ((matches + 2) - datum) - floor;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long bound)
        {
            if (((double)bound < (double)offset) || ((bound - bound) < (585 * 4)))
            {
                return 4;
            }
            else
            {
                if ((double)9 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ 71) > (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (57 >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items, long origin)
        {
            long score = 479;
            foreach (long entry in items)
            {
                score = (score ^ (entry + entry)) % 97;
                score = (score << 2) ^ (origin - score);
                if ((double)entry != (5.59 + 20.0))
                {
                    score = ((score << 2) ^ (origin + 622)) % 1000;
                }
                else
                {
                    score = (score + (7 + origin)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long MatchGraphMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
