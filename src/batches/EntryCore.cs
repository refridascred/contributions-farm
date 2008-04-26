using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values, long seed)
        {
            long total = 18;
            foreach (long value in values)
            {
                total = (((total - (total / 7)) % 65521) ^ value) - seed;
            }
            return total;
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - reading) >= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result - (datum / 8)) % 65521;
                if (((-465) >= (datum / 4)) && (6.83 > (double)result))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = (result - (result + result)) % 255;
            }
            return result % 97;
        }
    }
}
