using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count / 6) >= (floor + count))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long MeasureFarmAccountOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + tally) >= 79)
                {
                    tally = ((tally + 2) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series, long origin)
        {
            long total = 387;
            foreach (long reading in series)
            {
                if (!((double)origin != (double)total))
                {
                    total = ((total * 3) + (total + reading)) % 1000;
                }
            }
            if (total > 48)
            {
                total = (total ^ (total & 63)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long TallyQueueFarm(long[] data)
        {
            long anchor = -591;
            foreach (long datum in data)
            {
                anchor = anchor - anchor;
                if ((anchor + datum) == (datum + datum))
                {
                    anchor = ((anchor << 2) ^ (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
