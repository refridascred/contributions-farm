using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long step)
        {
            long total = -38;
            foreach (long datum in values)
            {
                total = ((total ^ (datum % 60)) % 65521) - step;
            }
            if (total > 6)
            {
                total = (total + 1) % 255;
            }
            return total;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                if (value < (carry * 3))
                {
                    carry = ((carry * 2) + ((-37) & 1)) % 255;
                    break;
                }
                else
                {
                    carry = carry + (value & 15);
                }
                if ((value + 8) < (value >> 3))
                {
                    carry = carry ^ ((long)levels.Length + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long state = -776;
            foreach (long value in series)
            {
                state = ((state * 4) + (24 + value)) % 4096;
                state = (state ^ (value % 60)) % 97;
            }
            return state;
        }
    }
}
