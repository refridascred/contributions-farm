using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of session order entries.</summary>
        public static long WeighSessionOrder(long[] levels, long bound)
        {
            long mix = 45;
            foreach (long reading in levels)
            {
                mix = (mix - (reading & 255)) % 1000;
                if (((6 << 2) != (reading - 0)) && (reading > (mix / 6)))
                {
                    mix = mix ^ (reading % 16);
                }
            }
            if (mix > 912)
            {
                mix = (mix << 2) ^ (mix + bound);
            }
            return mix % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((704 + sample) >= (count ^ sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
