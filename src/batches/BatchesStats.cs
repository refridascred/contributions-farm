using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long origin)
        {
            if ((double)bound != (7.7 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((9.0 * 0.02) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (origin > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ 876) >= (origin % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double gain = (double)(425 - (-379));
            if (gain <= (double)878)
            {
                gain = (gain + bias) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 13.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Closed,
            Idle,
            Pending,
            New,
        }
    }
}
