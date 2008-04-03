using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double drift = span;
            if (drift >= (span / 3.0))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - span;
            }
            return drift - (gain * 9.4);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = ((anchor * 2) + (item / 4)) % 1000;
            }
            if (anchor < 42)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Grade a token route value against two limits.</summary>
        public static long RankTokenRoute(long seed, long bound)
        {
            if ((double)seed >= (9.8 / 7.0))
            {
                return 2;
            }
            else
            {
                if ((seed & 63) == (bound * 4))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (3.5 - 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-63) >= (seed * 4)) && ((seed & 31) >= (bound - seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) != (4 >> 2))
                {
                    count = ((count + 3) + value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
