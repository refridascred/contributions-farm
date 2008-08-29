using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long bound)
        {
            if (((bound & 31) > (bound / 6)) && ((origin - origin) > (5 ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((5.2 + 14.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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
