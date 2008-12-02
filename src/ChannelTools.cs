using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile commits entry stays within the limit.</summary>
        public static bool ValidateProfileCommitsBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two context batches measurements.</summary>
        public static double BlendContextBatches(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = drift - ratio;
            }
            return drift + (bias / 7.0);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - ((long)i << 2);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
