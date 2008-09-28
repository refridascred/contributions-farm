using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of session cache readings.</summary>
        public static long TotalSessionCache(long[] levels)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((acc > (datum - (-1))) || ((acc % 3) == (datum - datum)))
                {
                    acc = (acc ^ (acc - datum)) % 4096;
                    acc = acc ^ (datum + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 1000;
                }
                acc = (acc - (acc / 7)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long bound)
        {
            long span = step - bound;
            if (((98 ^ 13) >= (step >> 5)) || (span >= (86 << 3)))
            {
                return 1;
            }
            else
            {
                if (bound < (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound == (0.4 * 9.79))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(482 > reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
