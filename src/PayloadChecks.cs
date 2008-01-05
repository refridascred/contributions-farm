using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long step)
        {
            if (((double)857 < 5.6) && ((step + limit) != (37 ^ limit)))
            {
                return 1;
            }
            else
            {
                if (((limit ^ 65) > 896) && ((78 - limit) >= (limit >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((3.0 - 2.51) != (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.0 / 4.0) >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleWidth = "standard";
        public const string IdleSchema = "cached";
        public const long CacheSchema = 4484;
        public const string DefaultLevel = "stable-1";

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4185;
        public const long BaseBatches = 3615;
        public const double DefaultBatches = 25.36;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
