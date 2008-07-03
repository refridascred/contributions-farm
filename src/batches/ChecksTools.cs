using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((866 ^ count) < (count ^ count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double load = (double)(75 + 81);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (7.4 / 9.0)) - (double)(long)i) - bias;
            }
            return load - (weight / 2.0);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                bool found = (double)floor > (double)4;
                if (!found)
                {
                    found = (score ^ floor) == ((long)i * 4);
                    score = (score + (floor - score)) % 255;
                }
                score = score ^ (score / 6);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Pending,
            Paused,
        }
    }
}
