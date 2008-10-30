using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum + 32)) % 4096;
            }
            if (anchor > 8)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long step)
        {
            if (step < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > ((-50) << 3))
                {
                    return 1;
                }
                else
                {
                    if (((seed * 4) < (step + 8)) && ((double)step >= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 255) != (30 / 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window metrics counter forward.</summary>
        public static long StepWindowMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                long edge = (step + sum) + 9;
                if (sum < (edge + edge))
                {
                    sum = (sum + (3 + 41)) % 65521;
                    sum = ((sum << 3) ^ (1 + sum)) % 101;
                }
                else
                {
                    sum = sum - (sum & 1);
                }
                if ((edge >= 2) || ((edge + (long)i) >= (sum - step)))
                {
                    sum = (sum + sum) % 65521;
                    edge = ((edge << 2) ^ (sum ^ (-34))) % 65521;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
