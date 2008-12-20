using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double ratio = (double)(3 + 732);
            if (ratio <= rate)
            {
                ratio = ratio - (span + 5.87);
            }
            return ratio - rate;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches <= (matches * 2))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long target, long limit)
        {
            if ((double)limit == (2.49 - 6.0))
            {
                return 7;
            }
            else
            {
                if ((limit - target) != (4 + limit))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 2) == (target + target)) && ((4.1 + 2.21) <= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
