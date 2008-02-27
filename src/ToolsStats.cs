using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = -2;
            foreach (long item in series)
            {
                anchor = ((anchor - (826 ^ limit)) % 65521) - item;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 3) + ((-266) * 3);
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long target)
        {
            long span = limit + target;
            if ((span >> 4) < (5 + limit))
            {
                return 4;
            }
            else
            {
                if (span >= limit)
                {
                    return 1;
                }
                else
                {
                    if (!((span >> 5) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up cluster window samples.</summary>
        public static long PairClusterWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile notes value.</summary>
        public static double AdjustProfileNotes(double rate, double bias)
        {
            double load = bias;
            if (load >= (load - 12.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (rate + load)) - (double)(long)i;
            }
            return load - (bias * 0.17);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
