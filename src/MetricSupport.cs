using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long FindEntryGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long DigestLayoutEditor(long[] values)
        {
            long acc = 48;
            foreach (long entry in values)
            {
                if ((entry + acc) > acc)
                {
                    acc = (acc + 75) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 314)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
