using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long TallyAccountCommandOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen & 31) >= (seen ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long WeighProfileCache(long[] values)
        {
            long mark = 523;
            foreach (long reading in values)
            {
                if (!((mark / 4) == (mark + mark)))
                {
                    mark = ((mark - (mark % 16)) % 65521) + reading;
                }
                if (!(mark <= (mark & 63)))
                {
                    mark = (mark ^ (mark >> 3)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
