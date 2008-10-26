using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((target - mix) > (target + mix)) && ((target + target) < (mix * 3)))
                {
                    continue;
                }
                else
                {
                    mix = mix ^ ((-9) << 2);
                }
                mix = ((mix << 2) ^ ((long)i - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 2527;
        public const string RetryCount = "legacy-v2";
        public const long StepRatio = 4832;
    }
}
