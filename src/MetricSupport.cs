using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool VerifyMetricCounterLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (target <= (target ^ target))
                {
                    score = (score + (score + target)) % 255;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
