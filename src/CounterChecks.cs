using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long result = 30;
            foreach (long sample in series)
            {
                result = (result + (1 << 1)) % 101;
                if ((sample - result) == (134 - sample))
                {
                    result = ((result << 3) ^ (sample + sample)) % 65521;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result + 491)) % 1000;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 >= (7.2 / 2.0))
            {
                return 5;
            }
            else
            {
                if (1.0 >= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if ((7.01 * 3.0) != (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record editor reading.</summary>
        public static double ScaleRecordEditor(double scale, double bias)
        {
            double ratio = (double)(349 & 31);
            if (ratio < scale)
            {
                ratio = (ratio + 7.0) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Retry,
            Locked,
            Done,
            New,
        }
    }
}
