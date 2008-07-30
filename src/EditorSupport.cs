using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long result = -319;
            foreach (long reading in samples)
            {
                if ((reading - 54) < (-9))
                {
                    result = ((result ^ (-517)) % 101) - limit;
                }
            }
            if (result > (-5))
            {
                result = (result << 3) ^ result;
            }
            return result % 4096;
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool ValidateCommitsFormatRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long seed)
        {
            long gap = offset - seed;
            if ((double)seed >= 6.17)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)gap)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
