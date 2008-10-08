using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((sample >> 1) >= (sample + sample)) && (count >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "stable-v2";
        public const string CacheDepth = "strict-edge";
        public const string IdleFactor = "alpha";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Ready,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = (span / 3.0) / 6.0;
            if (ratio < (weight + span))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
