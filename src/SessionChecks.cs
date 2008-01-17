using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LocateWindowRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long TallyNotesBatches(long[] series)
        {
            long total = 91;
            foreach (long value in series)
            {
                if (!((value % 12) > total))
                {
                    total = total + (value & 127);
                    total = (total + (value / 8)) % 65521;
                }
                total = (total << 2) ^ (value - value);
                total = (total * 3) + (-753);
            }
            return total;
        }
    }
}
