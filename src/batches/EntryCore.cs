using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long result = 31;
            foreach (long cell in series)
            {
                if ((result + 8) != (cell + cell))
                {
                    result = (result * 2) + (cell + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of stats commits readings.</summary>
        public static long PairStatsCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Draft,
        }
    }
}
