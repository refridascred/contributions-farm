using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen + floor) >= floor) && ((seen + 8) <= (datum + datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((score > (score + (long)i)) && ((double)score >= (7.1 / 5.0)))
                {
                    score = score - (bound << 3);
                }
                score = ((score * 2) + (long)i) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session context entries.</summary>
        public static long DigestSessionContext(long[] items)
        {
            long sum = 505;
            foreach (long sample in items)
            {
                sum = (sum - (sample + sum)) % 97;
            }
            return sum % 97;
        }
    }
}
