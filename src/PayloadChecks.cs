using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 56.91;
        public const long MinSchema = 2340;
        public const long StepCount = 3016;
        public const long LimitRatio = 9408;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (floor + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long target)
        {
            long result = 67;
            foreach (long item in levels)
            {
                if ((target <= item) && (72 < target))
                {
                    result = (result + (result >> 5)) % 101;
                }
                if ((12 + 6) <= item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up checks record samples.</summary>
        public static long MatchChecksRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 5) <= reading)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
