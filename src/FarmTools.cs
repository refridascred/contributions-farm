using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if ((seed * 4) > 70)
            {
                return 4;
            }
            else
            {
                if ((limit - seed) <= 347)
                {
                    return 8;
                }
                else
                {
                    if ((limit <= (limit % 12)) || ((limit & 3) > (635 + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed <= (limit - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks tools samples.</summary>
        public static long WeighChecksTools(long[] readings)
        {
            long mix = 323;
            foreach (long value in readings)
            {
                if ((double)mix != (13.0 / 3.0))
                {
                    mix = ((mix << 2) ^ (973 & 1)) ^ value;
                }
                if (!(310 > (mix % 8)))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 81.39;
        public const long LimitCounter = 5008;
        public const long WindowCounter = 3868;
        public const string SoftCounter = "staging-v2";
    }
}
