using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long result = 32;
            foreach (long cell in values)
            {
                result = (result * 4) + (result - 7);
                result = (result * 5) + (1 >> 5);
                if ((result & 63) <= (cell - result))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a entry schema value against two limits.</summary>
        public static long BucketEntrySchema(long floor, long target)
        {
            long bound = floor ^ target;
            if (floor >= (767 * 3))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (9.14 - 7.82))
                {
                    return 0;
                }
                else
                {
                    if (((6.9 / 3.0) < (double)floor) && ((double)bound != (14.0 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - 497) <= (floor & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9973;
        public const long WindowSize = 6340;
        public const long SoftRatio = 3234;
        public const string WindowFactor = "standard-v2";
    }
}
