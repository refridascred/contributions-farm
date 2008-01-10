using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long diff = limit - target;
            if ((target + (-3)) < (171 ^ limit))
            {
                return 3;
            }
            else
            {
                if ((double)target == (5.0 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if (96 <= (diff + diff))
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

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Failed,
            New,
            Retry,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ 150) != (item ^ offset))
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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2183;
        public const long HardDepth = 1151;
        public const long SoftContext = 496;
        public const double HardContext = 71.65;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series)
        {
            long mix = 345;
            foreach (long entry in series)
            {
                mix = (mix ^ (47 + entry)) % 65521;
            }
            return mix;
        }
    }
}
