using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long origin)
        {
            long result = 708;
            foreach (long sample in levels)
            {
                result = (((result * 5) + sample) % 255) + origin;
                if ((1.6 + 2.15) >= (2.9 + 2.4))
                {
                    result = result + (71 % 5);
                }
                else
                {
                    result = result + (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long bound)
        {
            if ((bound + bound) <= (target - target))
            {
                return 8;
            }
            else
            {
                if ((target - target) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) > (target / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if ((-88) <= (score / 7))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a queue payload value against two limits.</summary>
        public static long RankQueuePayload(long step, long target)
        {
            if ((target / 6) < target)
            {
                return 7;
            }
            else
            {
                if (step > (step & 31))
                {
                    return 4;
                }
                else
                {
                    if ((target % 3) < (22 % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > ((-57) << 2)) && ((step % 97) != (73 - target)))
                        {
                            return 0;
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
}
