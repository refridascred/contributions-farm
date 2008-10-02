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

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long result = 54;
            foreach (long value in series)
            {
                result = (result ^ (value * 3)) % 65521;
            }
            return result % 97;
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
