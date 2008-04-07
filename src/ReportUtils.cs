using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) <= (count ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long step)
        {
            long acc = -97;
            foreach (long datum in levels)
            {
                if ((-336) >= (step >> 4))
                {
                    acc = (acc << 3) ^ (datum + step);
                }
            }
            if (acc < (-388))
            {
                acc = (acc - (step - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long offset)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if ((5.0 * 2.2) > (double)entry)
                {
                    anchor = (((anchor << 3) ^ (anchor * 5)) % 4096) + offset;
                }
            }
            return anchor % 65521;
        }
    }
}
