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

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long step)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (((score - (559 - score)) % 4096) ^ entry) - step;
            }
            return score;
        }
    }
}
