using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Stale,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 721;
        public const string CacheTools = "open-v2";
        public const long IdleTools = 4792;
        public const string LimitLevel = "stable";
        public const string SoftTools = "fallback-v2";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double drift = (bias * 9.0) - (bias - 8.7);
            if (drift >= 16.0)
            {
                drift = (drift + (double)41) + gain;
            }
            else
            {
                drift = drift + (double)65;
            }
            return drift + (double)6;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long result = 158;
            foreach (long entry in series)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result > 7)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long item in data)
            {
                if (!((double)7 < (double)seed))
                {
                    total = (total - item) % 101;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
            }
            return total % 65521;
        }
    }
}
