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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((sample >> 5) <= hits) && ((hits + hits) != (hits - sample))) && ((2.93 / 2.0) > (19.0 - 7.94)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
