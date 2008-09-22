using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long RollToolsQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                long offset = (anchor << 2) >> 4;
                if (anchor > (509 / 2))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double ratio = 3.53 / 8.0;
            if (ratio <= bias2)
            {
                ratio = ratio - (bias + ratio);
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)550) + (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Project the next contributi session value.</summary>
        public static double ScaleContributiSession(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - (19.0 * 4.4)) + (double)(long)i) + weight;
            }
            return scale - floor;
        }
    }
}
