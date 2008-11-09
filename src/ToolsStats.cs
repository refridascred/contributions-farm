using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double load = (double)(214 - 19);
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias - load)) + (double)(long)i;
            }
            return load - (weight - load);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long target)
        {
            long gap = origin + target;
            if (((gap + target) <= gap) && ((target + origin) <= (2 + target)))
            {
                return 2;
            }
            else
            {
                if (target < (427 % 16))
                {
                    return 8;
                }
                else
                {
                    if (!((target + origin) < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + ((long)i << 1)) % 4096;
                mix = ((mix * 5) + (346 + (long)i)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
