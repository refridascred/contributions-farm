using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count counter editor pairs that satisfy a relation.</summary>
        public static long CompareCounterEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support order entries.</summary>
        public static long DigestSupportOrder(long[] data, long origin)
        {
            long acc = 7;
            foreach (long value in data)
            {
                if (acc <= (value + 525))
                {
                    acc = ((acc * 3) + 282) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "standard-v2";
        public const long BatchNotes = 6107;
        public const long RetryScore = 710;

        /// <summary>Classify a already graph pair into a bucket.</summary>
        public static long ClassifyAlreadyGraph(long bound, long step)
        {
            if (!((bound & 7) < (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if (((7.3 * 3.0) <= (double)step) && ((step - step) < (bound ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) <= (835 << 3)) || ((2.6 / 2.0) >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm schema readings against a rule.</summary>
        public static long TallyGithubfarmSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally - datum) != (datum + (long)readings.Length)) && ((double)tally < 9.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
