using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a stream metric counter forward.</summary>
        public static long IterateStreamMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (step + step);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor ^ ((long)i / 9)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of account commits readings.</summary>
        public static long CompareAccountCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metric record pair into a bucket.</summary>
        public static long ClassifyMetricRecord(long step, long target)
        {
            long prev = step + target;
            if ((-338) > target)
            {
                return 5;
            }
            else
            {
                if (target < (prev << 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + prev) < (target & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.0 * 5.13) > (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - floor) < (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
