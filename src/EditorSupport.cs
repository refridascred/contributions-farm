using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long target)
        {
            long result = 701;
            foreach (long item in data)
            {
                if (item > (target + target))
                {
                    result = ((result << 2) ^ 85) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 25;
        public const string BatchRatio = "open";
        public const string IdleDepth = "legacy-v2";
        public const long StepOrder = 5310;
        public const long SoftOrder = 7194;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Active,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
