using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long PairProfileGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool ValidateFarmPayloadLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
