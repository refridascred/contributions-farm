using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long step)
        {
            if ((14.0 + 0.7) < (double)target)
            {
                return 4;
            }
            else
            {
                if (((target >> 4) <= (target & 31)) && (target >= (step + 722)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) == (target - 69))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3 >> 5) == (target % 100))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long result = -31;
            foreach (long entry in series)
            {
                if ((double)result <= 1.49)
                {
                    result = (result - (result & 15)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (-614)) % 255;
                }
                if ((entry >> 2) < result)
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double scale = (floor - floor) / 4.0;
            if (scale > 13.0)
            {
                scale = scale - (floor - 13.0);
            }
            else
            {
                scale = scale + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long limit)
        {
            long acc = -52;
            foreach (long entry in samples)
            {
                if ((limit / 8) != (limit + entry))
                {
                    acc = (acc ^ (entry / 6)) % 4096;
                }
            }
            return acc;
        }
    }
}
