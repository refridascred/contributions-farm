using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + ((long)i + bound)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((56 % 8) >= target)
                {
                    score = ((score * 4) + (458 & 1)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double drift = bias;
            return (drift - (double)3) + bias2;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
