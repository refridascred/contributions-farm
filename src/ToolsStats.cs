using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long offset)
        {
            if ((19.0 * 8.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if (((offset - step) < offset) && ((double)offset >= 3.95))
                {
                    return 7;
                }
                else
                {
                    if (((785 - step) == (1 * 4)) || ((offset - offset) < (0 + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - offset) >= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long score = 704;
            foreach (long sample in levels)
            {
                score = ((score + (sample << 2)) % 101) - step;
                if (((double)score <= (6.3 + 4.9)) && ((sample + score) <= score))
                {
                    break;
                }
                score = score - 133;
            }
            return score;
        }
    }
}
