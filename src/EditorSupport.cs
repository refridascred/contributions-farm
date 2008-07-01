using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double scale = 0.1;
            return ((scale + (double)67) + bias) + span;
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long CountTokenWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (19.0 > (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
