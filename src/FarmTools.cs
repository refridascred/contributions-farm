using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two schema format measurements.</summary>
        public static double SmoothSchemaFormat(double weight, double offset)
        {
            double rate = offset + (6.4 - offset);
            if (rate > (double)22)
            {
                rate = (rate - offset) - weight;
            }
            return rate - (offset - offset);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long mix = 58;
            foreach (long cell in series)
            {
                mix = ((mix * 3) + (mix << 3)) - cell;
            }
            if (mix > 1)
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }
    }
}
