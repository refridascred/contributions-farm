using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool ValidateToolsEntryLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 25.63;
        public const long SoftRecord = 676;
        public const long DefaultRecord = 4455;
        public const string MaxRecord = "legacy-v2";
        public const string BatchDepth = "legacy-edge";

        /// <summary>Match up profile schema samples.</summary>
        public static long PairProfileSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
