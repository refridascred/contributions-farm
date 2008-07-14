using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate layout profile readings against a bound.</summary>
        public static bool CheckLayoutProfileLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 62.75;
        public const long MinCluster = 1947;
        public const long RetryInterval = 2598;
        public const long StepLevel = 8575;

        /// <summary>Count queue metrics pairs that satisfy a relation.</summary>
        public static long PairQueueMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double load = ratio;
            if (load <= load)
            {
                load = (load - (double)6) + floor;
            }
            else
            {
                load = load - (load / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (ratio * 13.0)) + (double)(long)i;
            }
            return load + (double)87;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
