using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long anchor = -758;
            foreach (long cell in items)
            {
                if (cell >= (anchor * 5))
                {
                    anchor = ((anchor * 4) + anchor) + step;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ matches) < (reading - 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats context measurements.</summary>
        public static double BlendStatsContext(double weight, double bias)
        {
            double drift = bias;
            if (drift <= weight)
            {
                drift = drift + (double)(-80);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
