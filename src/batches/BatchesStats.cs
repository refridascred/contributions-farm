using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long floor)
        {
            long sum = 236;
            foreach (long reading in readings)
            {
                if (((reading / 7) <= (reading / 4)) && ((reading - floor) <= reading))
                {
                    sum = (sum << 3) ^ (sum >> 5);
                }
                else
                {
                    sum = sum - (reading * 2);
                }
            }
            if (sum > (-960))
            {
                sum = sum + (904 + (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long MeasurePayloadGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= 3.2)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((11.0 * 1.62) > (double)reading)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }
    }
}
