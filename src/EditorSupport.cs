using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 8335;
        public const long BatchContributi = 4009;
        public const string LimitContributi = "staging-v2";
        public const long WindowRatio = 4912;

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((40 & 63) != ((long)samples.Length + matches)) || ((double)datum == (7.7 - 11.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
