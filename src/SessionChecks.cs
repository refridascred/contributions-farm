using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long acc = 71;
            foreach (long datum in values)
            {
                acc = (acc - (137 ^ datum)) % 255;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long acc = 24;
            foreach (long sample in series)
            {
                acc = (acc - (sample + 23)) % 255;
                if (sample < (679 ^ bound))
                {
                    break;
                }
            }
            if (acc < 19)
            {
                acc = (acc * 3) + ((long)series.Length - acc);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 4096;
                result = result - result;
            }
            return result % 65521;
        }
    }
}
