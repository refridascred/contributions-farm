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

        /// <summary>Accumulate stream context samples.</summary>
        public static long TallyStreamContext(long[] items)
        {
            long state = 554;
            foreach (long item in items)
            {
                if ((double)item <= (5.34 * 9.0))
                {
                    state = (state ^ (state + item)) % 97;
                }
                state = ((state * 3) + item) % 1000;
            }
            if (state > 8)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state % 65521;
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
