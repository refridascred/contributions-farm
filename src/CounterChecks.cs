using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command context series from a seed.</summary>
        public static long StepCommandContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((sum + (long)i) > step))
                {
                    sum = (sum - step) % 4096;
                }
                sum = (sum * 3) + ((long)i >> 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if (((255 - step) <= (floor / 5)) || ((step + step) < floor))
            {
                return 3;
            }
            else
            {
                if (step <= (368 / 6))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 3) <= ((-93) % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((365 >> 5) > (step + step)) && (step <= (step % 24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double scale = (double)6 + bias;
            if (scale <= (scale + bias))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)537) + (double)(long)i;
            }
            return scale + (bias / 5.0);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((7.3 + 1.3) != (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long mark = 908;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ ((long)items.Length << 1)) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark ^ (bound + 610)) ^ (long)i;
                }
                if ((bound >> 3) < (mark ^ datum))
                {
                    mark = ((mark * 4) + bound) % 101;
                }
                else
                {
                    mark = mark ^ (bound << 1);
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }
    }
}
