using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseRatio = 7042;
        public const string DefaultCounter = "stable-edge";
        public const long BatchRatio = 7204;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long CountReportLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - 544) <= 61)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
