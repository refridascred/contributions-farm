using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + mix;
                mix = mix + (mix - mix);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a support counter figure with a bias.</summary>
        public static double BlendSupportCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Fold a list of counter buffer readings.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long result = 94;
            foreach (long cell in levels)
            {
                if ((8 % 3) != (result + result))
                {
                    result = ((result + 601) % 4096) - cell;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
