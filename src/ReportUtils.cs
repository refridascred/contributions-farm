using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry report entry stays within the limit.</summary>
        public static bool GuardEntryReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every order record entry stays within the limit.</summary>
        public static bool CheckOrderRecordLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long step)
        {
            long acc = 98;
            foreach (long cell in values)
            {
                acc = acc - (acc + step);
                acc = (acc - cell) % 65521;
                if (acc >= (-3))
                {
                    acc = acc ^ cell;
                }
                if (((cell & 127) != (step - step)) || ((cell + step) < (61 + (-719))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
