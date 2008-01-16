using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long step)
        {
            long total = 747;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ datum) % 101;
                total = (total * 3) + (total - step);
            }
            return total % 65521;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((origin + bound) >= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (!((origin + bound) >= origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches <= (362 - matches)) || ((reading >> 1) <= (reading / 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Retry,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
