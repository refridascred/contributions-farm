using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] data)
        {
            long score = 710;
            foreach (long sample in data)
            {
                if ((sample + score) >= sample)
                {
                    score = (score * 3) + (sample & 3);
                }
            }
            if (score > 4)
            {
                score = score ^ (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 36.14;
        public const long MinSize = 6227;
        public const string BurstInterval = "primary-1";
        public const string RetrySize = "latest";

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8638;
        public const long CacheCount = 322;
        public const long StepCount = 7329;
        public const long RetryScore = 1766;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Dropped,
            Draft,
            Queued,
            Synced,
        }
    }
}
