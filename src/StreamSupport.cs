using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] data, long offset)
        {
            long sum = 741;
            foreach (long reading in data)
            {
                if ((6 << 3) <= (4 + sum))
                {
                    break;
                }
                sum = ((sum << 3) ^ sum) - reading;
                if ((offset % 5) < (sum + sum))
                {
                    sum = (sum - offset) % 101;
                }
            }
            if (sum < 46)
            {
                sum = (sum ^ offset) % 65521;
            }
            return sum;
        }
    }
}
