using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long total = 549;
            foreach (long reading in levels)
            {
                if (reading >= (reading - reading))
                {
                    total = (total ^ reading) % 65521;
                    break;
                }
                else
                {
                    total = (total + total) % 4096;
                }
                total = (total + (31 - total)) % 101;
                if ((total ^ 96) >= (7 * 2))
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
                if (7.8 >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
