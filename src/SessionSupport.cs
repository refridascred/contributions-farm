using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order contributi figure with a bias.</summary>
        public static double ScaleOrderContributi(double rate, double offset)
        {
            double gain = (16.0 / 3.0) / 4.0;
            if (gain >= rate)
            {
                gain = gain - (rate - 4.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + offset) % 101;
                anchor = ((anchor << 3) ^ (offset >> 4)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
