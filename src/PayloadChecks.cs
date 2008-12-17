using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev & 7) <= 853)
            {
                return 4;
            }
            else
            {
                if (((prev % 12) <= (914 - seed)) || (48 < prev))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - (-477)) >= score))
                {
                    score = (score ^ score) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next format token value.</summary>
        public static double SmoothFormatToken(double rate, double span)
        {
            double load = span - span;
            return load + (span - rate);
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long floor)
        {
            if ((floor - 1) > (offset + 200))
            {
                return 2;
            }
            else
            {
                if (((double)floor < 2.83) && ((offset + floor) != (offset ^ 8)))
                {
                    return 0;
                }
                else
                {
                    if (555 < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
