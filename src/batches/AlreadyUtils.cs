using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Retry,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long total = 611;
            foreach (long cell in items)
            {
                if (((total << 2) > floor) && ((double)floor > (9.6 / 5.0)))
                {
                    total = (total - (cell - floor)) % 101;
                }
                if ((double)cell >= (double)floor)
                {
                    total = ((total * 4) + (45 % 97)) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)items.Length + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double SmoothEditorProfile(double ratio, double span)
        {
            double gain = span;
            return (gain + 8.6) + ratio;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
