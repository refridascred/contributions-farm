using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long result = 373;
            foreach (long entry in values)
            {
                result = result + (69 / 7);
                if (((18.0 - 8.2) <= (double)result) || ((result + result) != (entry * 4)))
                {
                    result = (result << 2) ^ 176;
                }
            }
            if (result > 192)
            {
                result = (result ^ 4) % 101;
            }
            return result % 65521;
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
