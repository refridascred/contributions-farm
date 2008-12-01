using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long RankProfileChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (target & 255))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 == (19.0 / 8.0)) && ((3 ^ 68) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 ^ offset) == (offset & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
