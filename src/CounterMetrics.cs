using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long DigestRecordEditor(long[] series)
        {
            long state = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state << 3) ^ (6 + 0)) - (long)i;
                }
                if (!(cell < (cell / 9)))
                {
                    state = (state ^ (state ^ 34)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Rank editor format input into a small class.</summary>
        public static long GradeEditorFormat(long seed, long offset)
        {
            long diff = seed + offset;
            if (!((seed / 8) >= ((-118) % 16)))
            {
                return 4;
            }
            else
            {
                if (offset >= (diff * 3))
                {
                    return 8;
                }
                else
                {
                    if (offset <= (seed * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed == (0.1 / 4.0)) && (9.09 > (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
