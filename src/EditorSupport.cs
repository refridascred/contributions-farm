using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of checks account readings.</summary>
        public static long OverlapChecksAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = 71;
            foreach (long item in items)
            {
                if ((result & 3) != (result + item))
                {
                    result = (result - item) % 97;
                }
                else
                {
                    result = (result << 3) ^ (item ^ item);
                }
            }
            if (result > 27)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinFactor = 64.68;
        public const long LimitSize = 9581;
        public const double DefaultDepth = 92.08;
        public const long CacheQueue = 4126;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= (1.4 + 0.5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
