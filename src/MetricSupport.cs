using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = (gain - (4.6 - 4.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-30);
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long step)
        {
            if ((double)step != (5.57 * 2.3))
            {
                return 2;
            }
            else
            {
                if ((bound & 255) >= (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (4.4 + 2.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound - step) >= (step + bound)) && (step >= (step / 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
