using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] values, long target)
        {
            long total = 6;
            foreach (long value in values)
            {
                if ((long)values.Length <= 156)
                {
                    total = (((total * 3) + target) % 255) + value;
                }
            }
            if (total > (-497))
            {
                total = ((total * 2) + (total ^ target)) % 97;
            }
            return total;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Ready,
            Retry,
            New,
            Stale,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (!((94 - edge) >= (origin2 + origin)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (6 % 24))
                {
                    return 6;
                }
                else
                {
                    if ((edge & 127) > (edge >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin2 < (4.3 - 5.8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
