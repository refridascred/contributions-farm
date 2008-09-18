using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the metrics buffer series from a seed.</summary>
        public static long SeriesMetricsBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset > mix)
                {
                    mix = ((mix * 4) + (offset >> 3)) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long LookupEditorWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (((value % 24) == (step << 2)) && ((step & 7) == (value + step)))
                {
                    result = ((result * 4) + (value % 24)) % 65521;
                }
            }
            return result;
        }
    }
}
