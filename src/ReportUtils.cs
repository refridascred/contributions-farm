using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long acc = 257;
            foreach (long cell in series)
            {
                acc = acc - (cell + (long)series.Length);
            }
            if (acc > 9)
            {
                acc = acc + (seed / 5);
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long cur = limit ^ target;
            if (((limit * 2) < (target >> 1)) && ((limit % 12) < cur))
            {
                return 5;
            }
            else
            {
                if ((cur & 1) >= (target + cur))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
