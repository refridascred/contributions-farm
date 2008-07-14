using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long floor)
        {
            long next = limit ^ floor;
            if (((8.0 * 9.0) != (double)floor) || ((-1) <= (limit - limit)))
            {
                return 4;
            }
            else
            {
                if ((next + limit) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((6 >> 4) <= (next - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit & 63) <= (floor >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 62.75;
        public const long MinCluster = 1947;
        public const long RetryInterval = 2598;
        public const long StepLevel = 8575;

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long MeasureBatchBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ seen) <= (56 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
