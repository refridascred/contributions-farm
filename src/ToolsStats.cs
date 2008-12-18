using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step - step) > (acc & 1)))
                {
                    acc = acc ^ ((long)i / 2);
                    acc = acc + 891;
                }
                else
                {
                    acc = acc - (3 + 144);
                    acc = (acc - (296 + (long)i)) % 255;
                }
                acc = ((acc << 2) ^ (acc - (-60))) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long AuditWindowTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (9.6 > (double)seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count / 6) >= (-3)) && ((item >> 2) <= item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 8737;
        public const string BurstLevel = "strict-1";
        public const long LimitFactor = 5922;
    }
}
