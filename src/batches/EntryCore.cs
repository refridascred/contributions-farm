using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long CountPayloadProfileOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >= (target % 12)) && ((value & 15) > (tally + 217)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Closed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + offset) % 101;
                sum = sum ^ (sum + sum);
                sum = (sum - sum) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally % 3) >= bound) || ((bound - bound) == (426 >> 2)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream batches samples.</summary>
        public static long DigestStreamBatches(long[] items)
        {
            long anchor = 81;
            foreach (long sample in items)
            {
                anchor = anchor ^ (33 - sample);
                anchor = (anchor ^ (anchor % 2)) % 255;
            }
            return anchor;
        }
    }
}
