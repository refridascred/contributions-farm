using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank context order input into a small class.</summary>
        public static long ClassifyContextOrder(long limit, long offset)
        {
            if ((double)limit == (3.63 * 2.05))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) == (9 ^ (-99)))
                {
                    return 4;
                }
                else
                {
                    if (!((-69) < (offset >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (offset ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 640;
            foreach (long datum in readings)
            {
                if (datum > (mark << 3))
                {
                    continue;
                }
                if ((datum >> 4) >= 34)
                {
                    mark = ((mark + mark) % 4096) - step;
                }
                if (!(((-45) * 2) < (mark & 127)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double drift = gain / 5.0;
            if (drift > (drift * 18.0))
            {
                drift = (drift + (gain - 4.35)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)1;
        }
    }
}
