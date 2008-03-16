using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long GradeEditorPayload(long floor, long target)
        {
            long gap = floor + target;
            if ((target ^ gap) != (target << 2))
            {
                return 8;
            }
            else
            {
                if (!((gap - target) == (floor >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((6 & 255) <= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target % 24) < (floor & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (9 + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = bias - floor;
            }
            return bias - scale;
        }
    }
}
