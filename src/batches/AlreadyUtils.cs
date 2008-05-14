using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout checks series from a seed.</summary>
        public static long SeriesLayoutChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total - (offset + (-63))) % 4096;
                total = ((total << 2) ^ offset) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long MatchEditorFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + mark;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Synced,
            Ready,
            Idle,
        }
    }
}
