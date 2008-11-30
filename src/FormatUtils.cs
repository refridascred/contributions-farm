using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally >= (datum + tally))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitTimeout = "standard";
        public const string MinRatio = "standard-edge";
        public const long BaseStats = 451;
        public const long StepStats = 4988;
        public const long WindowStats = 7084;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel record readings.</summary>
        public static long WeighChannelRecord(long[] data, long offset)
        {
            long result = 653;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - entry) % 101) - (long)i;
                }
                if (!((offset + entry) >= (offset / 8)))
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
