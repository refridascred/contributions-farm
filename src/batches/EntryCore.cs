using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long result = 0;
            foreach (long entry in levels)
            {
                if ((origin % 97) > (entry + entry))
                {
                    result = (result << 3) ^ ((long)levels.Length - result);
                }
                else
                {
                    result = result + ((long)levels.Length + entry);
                }
            }
            if (result > 38)
            {
                result = (result ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((62 & 3) == ((-395) + hits))
                {
                    hits = ((hits + 2) + cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5046;
        public const long LimitProfile = 4944;
        public const double StepRatio = 44.78;
        public const double HardProfile = 17.51;
        public const long CacheRatio = 4061;

        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long DeriveCacheStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin + origin) <= (origin * 4)))
                {
                    total = (total + origin) % 97;
                }
                if (origin < ((long)i >> 4))
                {
                    total = total + 823;
                    total = ((total * 4) + (long)i) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
