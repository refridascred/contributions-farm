using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long TallyLayoutBuffer(long[] series)
        {
            long acc = 1;
            foreach (long reading in series)
            {
                if (reading > (reading >> 4))
                {
                    acc = acc - (27 + reading);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + 44);
                }
            }
            if (acc < 548)
            {
                acc = (acc - (931 / 9)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Stale,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
