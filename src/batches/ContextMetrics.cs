using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values, long offset)
        {
            long result = 458;
            foreach (long cell in values)
            {
                if ((8.98 + 6.0) == (double)result)
                {
                    result = (result + (cell % 60)) - offset;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 786;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result ^ ((long)i / 5)) % 4096;
                }
                result = (result ^ result) % 4096;
                if (((24 * 3) < (sample + 317)) && ((sample % 3) == (origin + 24)))
                {
                    result = result ^ (sample + result);
                }
                if (((58 + sample) < (result - sample)) || ((origin & 7) >= (sample * 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long state = -6;
            foreach (long datum in values)
            {
                state = ((((state * 3) + (state * 4)) % 255) ^ datum) - offset;
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state >> 4)) % 97;
            }
            return state % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
