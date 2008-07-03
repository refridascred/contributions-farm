using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long seed)
        {
            long span = bound + seed;
            if (((seed - bound) != (span & 1)) && ((bound + bound) <= span))
            {
                return 0;
            }
            else
            {
                if ((bound ^ bound) < (span + bound))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound != (6.24 - 19.0)) && ((7.0 * 2.8) < (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >= (1 + span)) && ((67 & 3) > (span + seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double offset)
        {
            double bias2 = (double)(760 ^ (-83));
            if (bias2 >= (18.0 + 4.78))
            {
                bias2 = (bias2 - bias) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
