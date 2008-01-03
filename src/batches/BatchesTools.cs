using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long result = -3;
            foreach (long value in levels)
            {
                if (((value << 2) != (offset ^ result)) || ((offset & 127) != (offset + 292)))
                {
                    result = (result ^ (offset >> 3)) % 101;
                    result = (result * 4) + (offset >> 3);
                    break;
                }
                result = (result + (result + offset)) % 101;
                if ((16 - 497) < result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
