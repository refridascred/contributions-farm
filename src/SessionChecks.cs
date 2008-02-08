using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain < (gain - offset))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + 12.0;
        }

        /// <summary>Grade a order batches value against two limits.</summary>
        public static long SortOrderBatches(long step, long offset)
        {
            if ((offset ^ offset) >= offset)
            {
                return 4;
            }
            else
            {
                if ((offset + 447) > (step - offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < 3.5)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 1) < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = acc + (6 & 255);
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc + (acc ^ 144)) % 255) + (long)i;
                    acc = acc - 0;
                }
                if (((acc + value) > (65 - value)) || (5 >= value))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            if (acc > 815)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }
    }
}
