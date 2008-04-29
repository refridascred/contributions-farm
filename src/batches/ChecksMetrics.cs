using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 2061;
        public const long BatchWidth = 3978;
        public const long LimitDepth = 3768;
        public const long SoftTools = 7207;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long span = floor ^ step;
            if (span < (span / 4))
            {
                return 3;
            }
            else
            {
                if (((26 - floor) == (floor + floor)) && ((floor / 9) < step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of tools window readings.</summary>
        public static long PairToolsWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long bound)
        {
            long carry = 53;
            foreach (long entry in readings)
            {
                if ((131 % 60) > entry)
                {
                    carry = carry - (bound + bound);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of command context entries.</summary>
        public static long ScoreCommandContext(long[] samples)
        {
            long anchor = 66;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor ^ (anchor - anchor)) % 97) - (long)i) + datum;
                }
                if (!(anchor >= (anchor << 3)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }
    }
}
