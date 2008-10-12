using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((floor << 3) >= (floor + floor)) || ((double)item != (3.0 - 9.02)))
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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally ^ value) >= 659)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long SeriesEditorFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + step) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
