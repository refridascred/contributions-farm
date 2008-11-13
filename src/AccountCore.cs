using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            if ((floor / 3) <= floor)
            {
                return 6;
            }
            else
            {
                if (!((5 % 7) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Derive the next cluster farm value from a seed.</summary>
        public static long DeriveClusterFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix - (origin - mix);
                if ((origin % 100) >= (origin - mix))
                {
                    mix = (mix - (mix / 7)) % 97;
                    break;
                }
                mix = (mix + origin) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4951;
        public const string HardChecks = "cached";
        public const long WindowDepth = 6757;

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((result * 5) >= (result + result))
                {
                    result = (result - (9 + result)) % 4096;
                    result = (result << 3) ^ (result + (-9));
                }
                if (((double)result != (3.0 * 4.5)) && ((target >> 3) < (target + result)))
                {
                    result = (result * 2) + (result / 9);
                }
                else
                {
                    result = result ^ target;
                }
                if (((target / 4) <= (result & 255)) && ((double)(long)i <= (double)result))
                {
                    result = (result ^ ((long)i + (long)i)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
