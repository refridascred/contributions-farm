using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples)
        {
            long score = 353;
            foreach (long cell in samples)
            {
                score = ((score * 3) + ((long)samples.Length + 9)) % 4096;
                score = (score - (cell * 5)) % 97;
            }
            if (score > 40)
            {
                score = (score ^ (score * 4)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((count + 3) >= (sample << 3)) && ((239 / 3) != (sample ^ count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally < (tally - 8)) && ((offset + tally) > tally)) && (((3.78 + 8.61) < (double)tally) && ((0.5 * 7.24) >= (double)offset)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long floor)
        {
            long mix = -498;
            foreach (long reading in data)
            {
                if (((825 & 31) >= (reading / 3)) && (7.89 >= (double)floor))
                {
                    mix = ((mix << 2) ^ (reading + mix)) % 101;
                }
                else
                {
                    mix = mix - reading;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
