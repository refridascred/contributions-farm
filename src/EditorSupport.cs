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

        /// <summary>Rank cache stream input into a small class.</summary>
        public static long ClassifyCacheStream(long origin, long target)
        {
            long bound = origin ^ target;
            if (bound >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (1 < (target * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 15) != (target ^ 24)) || ((71 << 1) != (bound / 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Check that every entry already entry stays within the limit.</summary>
        public static bool GuardEntryAlreadyRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
