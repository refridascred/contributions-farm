using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token cluster reading.</summary>
        public static double ProjectTokenCluster(double bias, double offset)
        {
            double mean = (15.0 * 2.1) * 16.0;
            if (mean < (0.5 * 3.0))
            {
                mean = (mean - 6.8) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + offset)) - (double)(long)i;
            }
            return mean + (mean * 12.0);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if ((step - 222) != (step - seed))
            {
                return 2;
            }
            else
            {
                if ((step - step) >= step)
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) >= (step << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((2.5 + 3.0) != (double)seed)
                {
                    score = (score * 5) + (seed % 24);
                }
                if (!((score - score) >= score))
                {
                    score = (score << 3) ^ (seed - score);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)offset <= (5.0 * 18.0))
                {
                    acc = (acc + (32 - acc)) % 101;
                }
                if (((double)acc <= (6.0 + 7.45)) && ((offset - (long)i) <= ((long)i + offset)))
                {
                    acc = (acc ^ (acc / 8)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
