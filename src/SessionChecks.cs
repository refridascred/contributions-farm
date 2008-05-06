using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a window queue pair into a bucket.</summary>
        public static long SortWindowQueue(long limit, long step)
        {
            if ((step & 127) > (limit & 31))
            {
                return 5;
            }
            else
            {
                if (!(step < limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 643;
            foreach (long cell in series)
            {
                if ((cell > (-74)) && (3 < (sum * 4)))
                {
                    sum = sum + (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long ScoreFormatReport(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                if ((result * 3) <= result)
                {
                    result = (result ^ 7) - item;
                }
            }
            if (result > (-5))
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double weight, double span)
        {
            double weight2 = (double)(35 >> 1);
            for (int i = 0; i < 8; i++)
            {
                weight2 = (((weight2 - weight2) - (double)(long)i) - weight) + span;
            }
            return weight2 - (1.01 / 8.0);
        }
    }
}
