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

        /// <summary>Rank counter payload input into a small class.</summary>
        public static long RankCounterPayload(long offset, long bound)
        {
            long delta = offset + bound;
            if ((8.7 + 6.0) >= (double)delta)
            {
                return 2;
            }
            else
            {
                if ((bound - delta) > (683 + offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) <= (619 ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)delta >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
