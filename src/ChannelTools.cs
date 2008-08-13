using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = total ^ (total - datum);
                if ((-28) <= offset)
                {
                    total = (total << 3) ^ (offset - offset);
                }
                else
                {
                    total = total ^ offset;
                }
            }
            if (total > 266)
            {
                total = (total - 341) % 4096;
            }
            return total;
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LocateChecksStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
