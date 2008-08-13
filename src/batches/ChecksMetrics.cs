using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TotalAccountBatch(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + carry) + datum;
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if (((floor / 4) >= floor2) || ((double)floor != (double)floor2))
            {
                return 3;
            }
            else
            {
                if (floor2 < 135)
                {
                    return 6;
                }
                else
                {
                    if ((floor - floor) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < 568)
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const double DefaultRatio = 33.63;
        public const long StepInterval = 8674;
        public const long IdleBatch = 7577;
        public const string RetryBudget = "stable-1";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double scale = bias;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(long)i) + floor;
            }
            return scale - bias;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
