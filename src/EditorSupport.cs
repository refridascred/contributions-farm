using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long RollEntryFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ 925) + (long)i2;
                }
                if (((long)i + anchor) > offset)
                {
                    anchor = anchor + offset;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series, long floor)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = (score - (datum & 1)) % 97;
                if ((double)datum < (2.9 + 1.7))
                {
                    score = score - (score * 5);
                }
                score = (score - (datum - floor)) % 4096;
                if (((long)series.Length / 8) >= (datum + datum))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (7.4 * 1.04))
                {
                    count = ((count + 3) + sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
