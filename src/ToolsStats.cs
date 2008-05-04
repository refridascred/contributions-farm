using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
                acc = (acc * 3) + acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long RollContributiEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= 12.0)
            {
                rate2 = (rate2 - (rate + rate2)) + bias;
            }
            else
            {
                rate2 = rate2 - (0.56 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)(-482);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((4.02 * 19.0) > (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double bias, double offset)
        {
            double mean = 0.2;
            if (mean <= 5.16)
            {
                mean = (mean + offset) + bias;
            }
            return mean + 9.4;
        }
    }
}
