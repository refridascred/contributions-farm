using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long acc = -49;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (datum + 62);
            }
            if (acc > 296)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading / 3) <= tally)
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi token readings.</summary>
        public static long WeighContributiToken(long[] series, long floor)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = (total - (floor << 1)) % 65521;
                if (((long)series.Length - value) < (floor << 2))
                {
                    total = total - (total << 2);
                }
                else
                {
                    total = (total ^ (total / 3)) % 97;
                }
            }
            return total;
        }
    }
}
