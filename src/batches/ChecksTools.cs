using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
