using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample % 3) > tally) || (((long)readings.Length + sample) > (sample * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)bound > (5.6 + 3.46))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ (seed ^ seed)) + (long)i2;
                }
                sum = (sum << 3) ^ (seed % 10);
                for (int i3 = 0; i3 < 8; i3++)
                {
                    sum = ((sum << 2) ^ 80) - (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long seed)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                acc = ((acc ^ (173 - acc)) ^ datum) - seed;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + seed;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
