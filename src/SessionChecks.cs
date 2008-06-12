using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a githubfarm metrics value against two limits.</summary>
        public static long ClassifyGithubfarmMetrics(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((double)span < (8.17 * 2.6))
            {
                return 4;
            }
            else
            {
                if ((seed + 8) < floor)
                {
                    return 3;
                }
                else
                {
                    if (((floor / 8) != (floor & 15)) || ((span & 31) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0.07 / 2.0) > (double)span) || ((51 * 5) > (seed ^ seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (9.1 - 4.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
