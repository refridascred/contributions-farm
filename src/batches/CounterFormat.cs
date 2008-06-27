using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((result >> 3) >= (cell * 3))
                {
                    result = (result * 5) + (68 / 3);
                }
            }
            if (result < 7)
            {
                result = result + (524 & 1);
            }
            return result;
        }

        /// <summary>Count context githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapContextGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
