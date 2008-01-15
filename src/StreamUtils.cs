using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-630) - step) <= ((-6) % 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor / 4) >= (floor << 1))
                {
                    mark = (mark * 3) + (53 & 63);
                    mark = (mark - (mark * 5)) % 97;
                }
                if ((9.0 - 7.0) <= (double)floor)
                {
                    mark = ((mark * 2) + ((long)i ^ floor)) % 255;
                }
                else
                {
                    mark = mark - mark;
                }
                mark = mark + (63 % 97);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Queued,
            Failed,
            New,
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((89 + hits) <= (hits / 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
