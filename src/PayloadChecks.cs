using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            if (15.0 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((floor - 323) >= (7 << 3))
                {
                    return 8;
                }
                else
                {
                    if ((origin <= (origin + origin)) || ((floor + floor) <= (origin >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (200 > (origin & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 32;
            foreach (long item in readings)
            {
                if (6.91 < (double)acc)
                {
                    acc = ((acc + (acc >> 1)) % 101) - item;
                }
            }
            return acc;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double ratio = (double)(84 % 100);
            if (ratio < (double)802)
            {
                ratio = (ratio + (double)(-700)) - weight;
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 8.8) + (double)(long)i;
            }
            return ratio - (offset / 8.0);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a command tools sample.</summary>
        public static long SeekCommandToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
