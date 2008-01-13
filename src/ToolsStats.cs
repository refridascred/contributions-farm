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

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = (bias + bias) + gain;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias / 6.0)) + (double)(long)i;
            }
            return bias - (double)948;
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
