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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((756 / 4) <= (count ^ count)) && ((21 ^ sample) < count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long CountPayloadOrderHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (offset > (value * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
