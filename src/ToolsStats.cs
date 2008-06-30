using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value >> 3) <= (value + bound))
                {
                    result = (result << 3) ^ (bound - result);
                }
            }
            if (result < 803)
            {
                result = ((result << 3) ^ (result + result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + 6) > (cell & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Count schema farm pairs that satisfy a relation.</summary>
        public static long CompareSchemaFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Paused,
            Dropped,
            Retry,
            New,
        }
    }
}
