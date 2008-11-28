using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a layout context value against two limits.</summary>
        public static long SortLayoutContext(long target, long floor)
        {
            if (floor >= (target * 3))
            {
                return 8;
            }
            else
            {
                if ((target / 4) < floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= (14.0 - 4.3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "cached-edge";
        public const long MaxBatches = 947;
        public const long BaseTimeout = 1961;
        public const string WindowBatches = "staging";

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long floor2)
        {
            long offset = floor - floor2;
            if (((floor2 % 3) == (floor2 - floor2)) || ((double)floor2 < (double)offset))
            {
                return 3;
            }
            else
            {
                if ((floor % 3) < (floor2 + floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long RollMetricsQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 3) + (61 & 31);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double span)
        {
            double load = ratio - (span / 7.0);
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }
    }
}
