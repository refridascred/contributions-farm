using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data)
        {
            long mix = 55;
            foreach (long cell in data)
            {
                mix = (((mix * 5) + (mix >> 1)) % 4096) ^ cell;
            }
            return mix;
        }

        /// <summary>Check that every commits route entry stays within the limit.</summary>
        public static bool CheckCommitsRouteRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Closed,
            Failed,
            New,
            Draft,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
