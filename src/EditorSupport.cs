using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Locked,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every layout schema entry stays within the limit.</summary>
        public static bool GuardLayoutSchemaRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 42.42;
        public const double MinStream = 30.72;
        public const long MaxSpan = 8798;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
