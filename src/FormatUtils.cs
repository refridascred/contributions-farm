using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long acc = 886;
            foreach (long datum in values)
            {
                if (21 < (86 + datum))
                {
                    acc = (acc * 3) + (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
