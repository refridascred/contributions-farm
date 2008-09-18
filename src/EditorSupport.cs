using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate metrics support samples.</summary>
        public static long FoldMetricsSupport(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = (sum ^ (sample ^ sample)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4627;
        public const long BatchOrder = 2271;
        public const string RetrySpan = "strict-1";
        public const double BaseWidth = 23.66;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Paused,
            Active,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool CheckFarmTokenBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
